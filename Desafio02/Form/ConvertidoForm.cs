using Desafio02.Form.JsonObjects;

namespace Desafio02.Form
{
    internal class ConvertidoForm
    {
        //Form voltado para a descompresao do json
        public double Rate { get; }
        public double Result { get; }
        public string From { get; }
        public string To { get; }
        public double Amount { get; }

        public JsonQuery Query { get; }

        public JsonInfo Info { get; }

        public ConvertidoForm(double result, JsonQuery query, JsonInfo info)
        {
            Rate = info.rate;
            Result = result;
            From = query.from;
            To = query.to;
            Amount = query.amount;
            Query = query;
            Info = info;
        }
    }
}
