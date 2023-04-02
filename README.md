
# AreaCalc
A library for figures' area calculation

# Basic usage

```
public void ConfigureServices(IServiceCollection services)
{
	services.AddAreaCalc()
			.AddStrategy<Triangle, TriangleAreaStrategy>();
}
```
And then
```
public class SomeClass
{
	private readonly IAreaStrategy<TriangleAreaStrategy> _triangleStrategy;
	
	public SomeClass(IAreaStrategy<TriangleAreaStrategy> triangleStrategy)
	{
		_triangleStrategy = triangleStrategy;
	}
	
	public void SomeMethod()
	{
		var triangle = new Triangle(3, 4, 5);
		var area = _triangleStrategy.CalcArea(figure);
	}
}
```

In order to add more figures, you need to implement the `IFigure` and `IAreaStrategy` interfaces, and use your implementations with `.AddStrategy<TFigure, TStrategy>()` extension.

The default tolerance used for `double` comparison is `0.001d`. To override it, pass the desired tolerance to the `.AddAreaCalc()` method, like this:
```
	services.AddAreaCalc(0.0000000001d);
```
