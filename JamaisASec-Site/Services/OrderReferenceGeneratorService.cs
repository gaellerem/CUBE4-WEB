namespace JamaisASec_Site.Services
{
    public class OrderReferenceGeneratorService
    {
        private Random random = new Random();

        public string GenerateOrderReference(int length = 12)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXYZ0123456789";
            char[] reference_id = new char[length];

            for (int i = 0; i < reference_id.Length; i++)
            {
                reference_id[i] = chars[random.Next(chars.Length)];
            }

            return "COM-" + new string(reference_id);
          }
    }
}
