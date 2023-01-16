namespace Desafio02.Form.JsonObjects
{
    internal class JsonQuery
    {
        public string from { get; }
        public string to { get;}
        public int amount { get; }

        public JsonQuery(string from, string to, int amount)
        {
            this.from = from;
            this.to = to;
            this.amount = amount;
        }
    }
}
