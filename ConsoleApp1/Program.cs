// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        UiConfig uiConfig = new UiConfig();


        //melakukan pengecekan untuk bahasa yang akan ditampilkan nantinya
        if (uiConfig.config.lang == "en")
        {
            // meminta input berupa nominal yang ingin di transfer
            Console.WriteLine("Please insert the amount of money to transfer");
            int inputNominal = Convert.ToInt32(Console.ReadLine());

            //melakukan pengecekan apakah nominal yang diinput lebih kecil sama dengan
            // atau lebih besar dari nominal threshold yang sudah ditentukan
            if (inputNominal <=  uiConfig.config.transfer.threshold)
            { 
                //menampikan biaya transfer dan total jumlah transfer setelah penambahan fee
                Console.WriteLine($"Transfer fee = {uiConfig.config.transfer.low_fee} (Low fee)");
                Console.WriteLine($"Total amount = {uiConfig.config.transfer.low_fee+inputNominal}");
            } else if (inputNominal > uiConfig.config.transfer.threshold)
            {
                //menampikan biaya transfer dan total jumlah transfer setelah penambahan fee
                Console.WriteLine($"Transfer fee = {uiConfig.config.transfer.high_fee} (High fee)");
                Console.WriteLine($"Total amount = {uiConfig.config.transfer.high_fee + inputNominal}");
            }
            // meminta input berupa konfirmasi transaksi
            Console.WriteLine();
            Console.WriteLine($"Please type {uiConfig.config.confirmation.en} to confirm the transaction");
            string konfirmasi = Console.ReadLine();
            
            //jika transaksi berhasil
            if ( konfirmasi == "yes")
            {
                Console.WriteLine("The transfer is completed");
            }
            //transaksi gagal
            else
            {
                Console.WriteLine("Transfer is cancelled");
            }

        }
        //melakukan pengecekan apakah nominal yang diinput lebih kecil sama dengan
        // atau lebih besar dari nominal threshold yang sudah ditentukan
        else if (uiConfig.config.lang == "id")
        {
            // meminta input berupa nominal yang ingin di transfer
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer");
            int inputNominal = Convert.ToInt32(Console.ReadLine());
            if (inputNominal <= uiConfig.config.transfer.threshold)
            {
                //menampikan biaya transfer dan total jumlah transfer setelah penambahan fee
                Console.WriteLine($"Biaya Transfer = {uiConfig.config.transfer.low_fee} (Low fee)");
                Console.WriteLine($"Total amount = {uiConfig.config.transfer.low_fee + inputNominal}");
            }
            else if (inputNominal > uiConfig.config.transfer.threshold)
            {
                //menampikan biaya transfer dan total jumlah transfer setelah penambahan fee
                Console.WriteLine($"Biaya Transfer = {uiConfig.config.transfer.high_fee} (High fee)");
                Console.WriteLine($"Total amount = {uiConfig.config.transfer.high_fee + inputNominal}");
            }
            
            // meminta input berupa konfirmasi transaksi
            Console.WriteLine();
            Console.WriteLine($"Ketik {uiConfig.config.confirmation.id} untuk mengonfirmasi transaksi");
            string konfirmasi = Console.ReadLine();

            //transaksi berhasil
            if (konfirmasi == "ya")
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            //transaksi gagal
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }
    }
}
