namespace DesingPatterns.CustomClass;
internal class Hijo : Padre
{
    public string? NameHijo { get; set; }

    public override string ToString()
    {
        return $"Class Name: {base.ToString()}, Properties Values: {NameHijo}, {NamePadre}";
    }
}
