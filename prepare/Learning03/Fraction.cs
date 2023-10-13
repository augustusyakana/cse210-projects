public class Fraction {
    
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int num){
        _top = num;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop() {
        return _top;
    }

    public void SetTop(int numerator){
        _top = numerator;
    }

    public void SetBottom(int denominator) {
        _bottom = denominator;
    }

    public int GetBottom(){
        return _bottom;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}