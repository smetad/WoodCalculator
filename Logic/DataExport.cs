using ClosedXML.Excel;
using System.Collections.Generic;
using System.IO;
using woodcalc_00.Model;

namespace woodcalc_00._model
{
    public class DataExport : NotifyPropertyChanged
    {
        private readonly List<Log> dataList;
        int index;

        public DataExport(List<Log> exportList)
        {
            index = 1;
            dataList = new List<Log>(exportList);
        }

        public void CreateCSV(string path)
        {
            using StreamWriter sw = new StreamWriter(path + "/export.csv", false, System.Text.Encoding.UTF8);
            sw.Write("ID;Výpočet;Objem;Délka;Průmět čepu;Průměř středu;Průměr čela;Jakost,Druh dřeviny;Kůra;Poznámka");
            for (int i = 0; i < dataList.Count; i++)
            {
                sw.Write(sw.NewLine);
                sw.Write("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}",
                         i,
                         dataList[i].Calculation.TypeOfCalculation,
                         dataList[i].Volume,
                         dataList[i].Length,
                         dataList[i].DiameterBottom,
                         dataList[i].DiameterMiddle,
                         dataList[i].DiameterTop,
                         dataList[i].Quality.QualityClass, 
                         dataList[i].Tree.TypeOfTree,
                         dataList[i].Bark,
                         dataList[i].Tag);
            }
            sw.Close();
        }       
        public void CreateExcel(string path)
        {
            using XLWorkbook workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Export dat");

            worksheet.Cell(1, index++).Value = "ID";
            worksheet.Cell(1, index++).Value = "Výpočet";
            worksheet.Cell(1, index++).Value = "Objem";
            worksheet.Cell(1, index++).Value = "Délka";
            worksheet.Cell(1, index++).Value = "Průměr čepu";
            worksheet.Cell(1, index++).Value = "Průměr středu";
            worksheet.Cell(1, index++).Value = "Průměr čela";
            worksheet.Cell(1, index++).Value = "Cena";
            worksheet.Cell(1, index++).Value = "Jakost";
            worksheet.Cell(1, index++).Value = "Druh dřeviny";
            worksheet.Cell(1, index++).Value = "Kůra";
            worksheet.Cell(1, index).Value = "Poznámka";

            for (int i = 0; i < dataList.Count; i++)
            {
                int j = i + 2;
                worksheet.Cell(j, 1).Value = i + 1;
                worksheet.Cell(j, 2).Value = dataList[i].Calculation.TypeOfCalculation;
                worksheet.Cell(j, 3).Value = dataList[i].Volume;
                worksheet.Cell(j, 4).Value = dataList[i].Length;
                worksheet.Cell(j, 5).Value = dataList[i].DiameterTop;
                worksheet.Cell(j, 6).Value = dataList[i].DiameterMiddle;
                worksheet.Cell(j, 7).Value = dataList[i].DiameterBottom;
                worksheet.Cell(j, 8).Value = dataList[i].Value;
                worksheet.Cell(j, 9).Value = dataList[i].Quality.QualityClass;
                worksheet.Cell(j, 10).Value = dataList[i].Tree.TypeOfTree;
                worksheet.Cell(j, 11).Value = dataList[i].Bark;
                worksheet.Cell(j, 12).Value = dataList[i].Tag;
                j++;
            }
            workbook.SaveAs(path + "/export.xlsx");
        }
    }
}
