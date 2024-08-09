using System.Globalization;


namespace AutoPropriedades_;

class Aluno{
   public string Nome;
   public double Nota1;
   public double Nota2;
   public double Nota3;
    

   public double NotasAluno()
   {
      return Nota1 + Nota2 + Nota3;
   }
   
   public override string ToString()
   {
      return "NOTA FINAL: " + NotasAluno().ToString("F2");
   }

    //Essa é uma maneria de se fazer com ternário
    public bool ResultadoFinal()
    {
        return NotasAluno() >= 60;
    }
       
    public double PontosEmFalta()
    {
        return 60 - NotasAluno();
    }
    
}