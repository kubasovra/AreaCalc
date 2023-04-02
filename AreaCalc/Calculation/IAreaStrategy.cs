using AreaCalc.Figures;

namespace AreaCalc.Calculation
{
    public interface IAreaStrategy<in TFigure>
        where TFigure : IFigure
    {
        double CalcArea(TFigure figure);
    }
}
