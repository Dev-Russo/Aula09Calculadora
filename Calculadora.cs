using System;
using System.Globalization;

namespace Calculadora09
{
    public class Calculadora
    {
        public decimal v1 {get; set;}
        public decimal v2 {get; set;}

        public Calculadora(){}
        public Calculadora(decimal v1, decimal v2){
            this.v1 = v1;
            this.v2 = v2;
        }

        internal string Calcular()
        {
            throw new NotImplementedException();
        }

        private static string error = "Não é um número válido";
        public string VerificarNumero(string input){
            decimal result;
            if(string.IsNullOrEmpty(input)){
                return error;
            }else{
                foreach(char c in input){
                    if( (c.Equals('.') || c.Equals(',')) && !decimal.TryParse(c.ToString(), NumberStyles.Number, CultureInfo.CurrentCulture, out result))
                    {
                        return error;
                    }
                }
            }
           return string.Empty; 
        }
        
        private decimal Somar(decimal v1, decimal v2 ){
            return v1+v2;
        }
        private decimal Subtrair(decimal v1, decimal v2){
            return v1-v2;
        }
        private decimal Dividir(decimal v1, decimal v2){
            return v1/v2;
        }
        private decimal Multiplicar(decimal v1, decimal v2){
            return v1*v2;
        }
        public string Calcular(string v1, string operacao, string v2){
            string resultadoVerificacao = this.VerificarNumero(v1);
            if(!string.IsNullOrEmpty(resultadoVerificacao)){
                return resultadoVerificacao;
            }
            resultadoVerificacao = this.VerificarNumero(v2);
            if(!string.IsNullOrEmpty(resultadoVerificacao)){
                return resultadoVerificacao;
            }
            
            switch (operacao)
            {
                case "+":
                return Somar(decimal.Parse(v1), decimal.Parse(v2)).ToString();
                case "-":
                return Subtrair(decimal.Parse(v1), decimal.Parse(v2)).ToString();
                case "/":
                if(v2.Equals("0")) 
                    return "Não é possivel divisão por zero";
                return Dividir(decimal.Parse(v1), decimal.Parse(v2)).ToString();
                case "*":
                return Multiplicar(decimal.Parse(v1), decimal.Parse(v2)).ToString();
                default:
                return "Operação não reconhecida."; 
            }
        }

    }
}