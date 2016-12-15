@echo off
cls
"%~dp0\.nuget\nuget.exe" "install" "fake" "-OutputDirectory" "tools" "-ExcludeVersion" -version 4.46.1 -ConfigFile ".\.nuget\nuget.config"
"%~dp0\.nuget\nuget.exe" "install" "nunit" "-OutputDirectory" "tools" "-ExcludeVersion" -version 2.6.3 -ConfigFile ".\.nuget\nuget.config"
"%~dp0\.nuget\nuget.exe" "install" "nunit.runners" "-OutputDirectory" "tools" "-ExcludeVersion" -version 2.6.3 -ConfigFile ".\.nuget\nuget.config"
"%~dp0\tools\FAKE\tools\Fake.exe" build.fsx

