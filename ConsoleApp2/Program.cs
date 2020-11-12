using System;
namespace ConsoleApp2
{
    class Program
    {
        static Random rand = new Random();
        static string tobase64(string inpoot)
        {
            string plainText = "{\"textures\":{\"SKIN\":{\"url\":\"" + inpoot + "\"}}} ";
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return  System.Convert.ToBase64String(plainTextBytes);
        }
        static string randHex()
        {
            int n = rand.Next(16);
            string outs= n.ToString("x");
            return outs;
        }
        static string uuid()
        {
            string uuids = "";
            for (int i = 0; i < 8; i++)
            {
                uuids += randHex();
            }
            uuids += "-";
            for (int i = 0; i < 4; i++)
            {
                uuids += randHex();
            }
            uuids += "-";
            for (int i = 0; i < 4; i++)
            {
                uuids += randHex();
            }
            uuids += "-";
            for (int i = 0; i < 4; i++)
            {
                uuids += randHex();
            }
            uuids += "-";
            for (int i = 0; i < 12; i++)
            {
                uuids += randHex();
            }
            string uuidsex = "[I;";
            uuidsex += Convert.ToString(rand.Next(-2147483648, 2147483647));
            uuidsex += ",";
            uuidsex += Convert.ToString(rand.Next(-2147483648, 2147483647));
            uuidsex += ",";
            uuidsex += Convert.ToString(rand.Next(-2147483648, 2147483647));
            uuidsex += ",";
            uuidsex += Convert.ToString(rand.Next(-2147483648, 2147483647));
            uuidsex += "]";
            return uuidsex;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на скин");
            string lnk = Console.ReadLine();
            string cmd = "/give @p minecraft:player_head{SkullOwner:{Id:" + uuid();
            cmd+=",Properties:{textures:[{Value:\"" + tobase64(lnk) + "\"}]},Name:\"JavaJumper\"}}";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cmd);
            Console.ResetColor();
            //Clipboard.SetText(cmd);
            //Console.WriteLine("Комманда скопирована в буфер обмена");
            Console.WriteLine("Скопируйте зеленый текст в коммандный блок и активируйте его");
        }
    }
}//Name:\"JavaJumper\",
/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */