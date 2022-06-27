// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




do
{

    System.Data.DataTable dt = new System.Data.DataTable();
    dt.Columns.Add("Col1", typeof(int));
    dt.Rows.Add(1);

    System.Data.DataTable dt2 = new System.Data.DataTable();
    dt2.Columns.Add("Col1", typeof(string));
    dt2.Load(dt.CreateDataReader(), System.Data.LoadOption.OverwriteChanges);

    decimal tarih = 20220514;
    decimal Saat = 1820;
    int ccc;

    if (Saat.ToString().Length != 6 && Saat.ToString().Length != 5)

        ccc = Saat.ToString().Length;
    else
        ccc = Saat.ToString().Length;




    var rrr =  GetTarihSaatStr(tarih, Saat);

    var lll = Saat.ToString().Length;
    DateTime ddd = new DateTime();
    string sss = Saat.ToString().Length == 6 
        ? $"{Saat.ToString().Substring(0, 2)}:{Saat.ToString().Substring(2, 2)}:{Saat.ToString().Substring(4, 2)}" 
        : $"{Saat.ToString().Substring(0, 1)}:{Saat.ToString().Substring(1, 2)}:{Saat.ToString().Substring(3, 2)}";

    DateTime.TryParse(sss, out ddd);
    string aaa = $"{tarih.ToString().Substring(6, 2)}/{tarih.ToString().Substring(4, 2)}/{tarih.ToString().Substring(0, 4)}";

    DateTime.TryParse(aaa, out ddd);

    var aa = ddd;


} while (true);




string  GetTarihSaatStr(decimal Terstarih, decimal Saat)
{
    
    return $"{GetTarihStr(Terstarih)} {GetSaatStr(Saat)}";
    
}

string GetTarihStr(decimal tarih)
{
    return $"{tarih.ToString().Substring(6, 2)}.{tarih.ToString().Substring(4, 2)}.{tarih.ToString().Substring(0, 4)}";
}

string GetSaatStr(decimal Saat)
{
    return Saat.ToString().Length == 6
        ? $"{Saat.ToString().Substring(0, 2)}:{Saat.ToString().Substring(2, 2)}:{Saat.ToString().Substring(4, 2)}"
        : $"{Saat.ToString().Substring(0, 1)}:{Saat.ToString().Substring(1, 2)}:{Saat.ToString().Substring(3, 2)}";
    
}

