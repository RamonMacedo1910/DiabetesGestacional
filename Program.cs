Console.WriteLine("-=-Diabetes gestacionais-=-");

int glicemia;
string diagnostico;

Console.WriteLine("Diga a sua quantidade de glicemia em mg/dL");
glicemia = Convert.ToInt32(Console.ReadLine());



    if (glicemia > 126 )
        {
            diagnostico = "Diabetes Mellitus na Gravidez";
        }
    else 
        {
            if ( glicemia >= 92 )
                {
                    diagnostico = "Compatível com Diabetes Gestacional";
                }
            else 
                {
                    diagnostico = "reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
                } 
        }

Console.WriteLine($"o seu diagnostico é:{diagnostico}.");