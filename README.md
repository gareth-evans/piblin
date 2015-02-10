# piblin
Piblin is .NET library for composing applications from chainable, reusable components. The components are called pipes and they implement a derivation of ``IPipe``.

The simplest of which is `IPipe<TIn,TOut>` which takes a single argument and returns a single value. This is the full interface:

```csharp

public inteface IPipe<TIn, TOut>
{
    TOut Execute(TIn input);
}

```




