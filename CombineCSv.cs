using System;
using System.IO;
namespace DoSDetection {
    class CombineCSV {
        public void combineCSV(string folder) {
            string[] result = Directory.GetFiles(folder,"*.csv");
            if(result.Length == 0) {
                throw new Exception("No input csv files are not found");
            }
            string output = Path.Combine(folder,"data.csv");
            bool header = true;
            try {
                using(StreamWriter sw = new StreamWriter(output)) {
                    foreach(string file in result) {
                        using(StreamReader sr = new StreamReader(file)) {
                            string line;
                            if(header) {
                                line = sr.ReadLine();
                                sw.WriteLine(line);
                                header = false;
                            } else {
                                sr.ReadLine();
                            }
                            while((line = sr.ReadLine()) != null) {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
            } catch(Exception e) {
                throw new Exception($"Error in cmbining CSV file and the error is {e.Message}");
            }
        }
    }
}