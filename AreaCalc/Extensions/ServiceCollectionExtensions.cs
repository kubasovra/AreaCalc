using AreaCalc.Calculation;
using AreaCalc.Figures;
using Microsoft.Extensions.DependencyInjection;

namespace AreaCalc.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAreaCalc(
            this IServiceCollection services,
            double doubleComparisonTolerance = 0.001d)
        {
            services.AddSingleton(new DoubleToleranceComparer(doubleComparisonTolerance));
            return services;
        }

        public static IServiceCollection AddAreaStrategy<TFigure, TStrategy>(this IServiceCollection services)
            where TFigure : class, IFigure
            where TStrategy : class, IAreaStrategy<TFigure>
        {
            services.AddTransient<IAreaStrategy<TFigure>, TStrategy>();
            return services;
        }
    }
}
