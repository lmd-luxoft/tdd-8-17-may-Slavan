namespace TDDKata.Lib
{
    public class Calc
    {
        public int Add(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return 0;

            expression = expression.Replace("  ", " ");
            var args = expression.Trim().Split(' ');
            if (args.Length > 2)
                throw new ArgumentException(" To much inputs");

            var values = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
                if (!int.TryParse(args[i], out values[i]))
                    throw new ArgumentException($"{i} argument '{args[i]}' is not valid int");

            if (values.Length == 1)
                return values[0];

            return values[0] + values[1];
        }
    }
}