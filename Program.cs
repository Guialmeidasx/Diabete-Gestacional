int glicemia;
string diagnostico;
ConsoleColor CorResultado;

Console.WriteLine(" ||| Diabetes Gestacional |||\n");

Console.Write("Glicemia (em mg/dL) =>");
glicemia = Convert.ToInt32(Console.ReadLine());

if (glicemia > 126)
{
    diagnostico = "- Diabetes Mellitus na gravidez -";
    CorResultado = ConsoleColor.Red;
}
else
{
    if (glicemia >= 92)
    {
        diagnostico = "- Compatível com Diabetes Gestacional -";
        CorResultado = ConsoleColor.Yellow;
    }
    else
    {
        diagnostico = "- Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose -";
        CorResultado = ConsoleColor.Green;
    }
}

Console.ForegroundColor = CorResultado;

Console.WriteLine();
Console.WriteLine(diagnostico);

Console.ResetColor();
