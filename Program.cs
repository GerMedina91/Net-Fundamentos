using Platzi_Escuela.App;

CoreEscuela core = new CoreEscuela();
core.InitEscuela();

Console.WriteLine(core.Escuela.ToString());
foreach (var curso in core.Escuela.Cursos)
{
    Console.WriteLine("////////////////////////////////////////////");
    Console.WriteLine(core.ImprimirEvaluaciones(curso));
}


Console.ReadLine();