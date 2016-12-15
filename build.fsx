#r "tools/FAKE/tools/FakeLib.dll" // include Fake lib
open System
open System.IO
open Fake 
open Fake.NuGet
open Fake.AssemblyInfoFile

// Version Details
let major = 1
let minor = 1
let revision =
    if BuildServerHelper.isLocalBuild then "0"
    else BuildServerHelper.buildVersion

let version = String.Format("{0}.{1}.{2}", major, minor, revision)

BuildServerHelper.buildVersion = version

let solutionDir = @".\"
let outputDir = @".\output"
let buildDir  = outputDir + @"\build"
let testDir  = outputDir + @"\test"

let nuspecPath = @".\app\Piblin\Piblin.nuspec"

trace ("using version " + version)

Target "Clean" (fun _ ->
      CleanDirs [outputDir]
    )

Target "RestorePackages" (fun _ ->
    RestorePackages()
   )

Target "BuildTest" (fun _ ->
    !! @"/**/*.Test.csproj"
      |> MSBuildDebug testDir "Clean;Build"
      |> Log "TestBuild-Output: "
)

Target "Test" (fun _ ->
    !! (testDir + @"\*.Test*.dll")
      |> NUnit (fun p ->
                 {p with
                   DisableShadowCopy = true;
                   OutputFile = outputDir + @"\TestResults.xml"})
)

Target "Build"(fun _ -> 

    let solutionInfoFile = solutionDir + "SolutionInfo.cs"
    let fi = new FileInfo(solutionInfoFile)
    File.SetAttributes(solutionInfoFile, fi.Attributes &&& ~~~FileAttributes.ReadOnly)

    CreateCSharpAssemblyInfo solutionInfoFile
        [
         Attribute.Version version
         Attribute.FileVersion version]  

    !! @"/**/Piblin.csproj"
      |> MSBuildRelease buildDir "Clean;Build"
      |> Log "TestBuild-Output: "
    )

Target "Publish" (fun _ ->
    let packageDir = outputDir + @"\package"
    let packageLibDir = packageDir + @"\lib"
    let packageFrameworkDir = packageLibDir + @"\net40"

    let filesToPackage  = 
        !! (buildDir + "\*.*")
            -- (buildDir + "\*.pdb")

    CopyFiles packageFrameworkDir filesToPackage

    let nuspecTempPath = Path.GetTempFileName()
    CopyFile nuspecTempPath nuspecPath
    let fi = new FileInfo(nuspecTempPath)
    File.SetAttributes(nuspecTempPath, fi.Attributes &&& ~~~FileAttributes.ReadOnly)
    
    NuGet (fun p ->
        {p with
            Project = "Piblin" 
            Version = version
            WorkingDir = packageDir
            OutputPath = packageDir
            Publish = true
            PublishUrl = "http://slon01ap224u/nuget/api/v2/package"
            AccessKey = "BF941F6B-9A24-451A-81A7-55B8182BE8F5"
        }) nuspecTempPath
)

"Clean"
   // ==>"BuildTest"
   //     ==> "Test"
            ==> "Build"
               ==> "Publish"

Run "Publish" 