using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Merge_Intervall
{
    public partial class MergeIntervallView : Form
    {
        public MergeIntervallView()
        {
            InitializeComponent();
        }

        // "Open and Run" executes a filedialog where the user can select one .txt file
        // The result is displayed in the two textboxes
        private void OpenNRun_Click(object sender, EventArgs e)
        {
            string path = GetFile();
            pathBox.Text = path;
            resultBox.Text = "Imported data:\n"
                + string.Join("", CalculateIntervall(GetData(path))).Replace('(', '[').Replace(')', ']')
                + "\n\n";

            // To update the UI after changes were done within the textboxes
            Application.DoEvents();
        }

        // GetFile() returns the path to the selected file from the filedialog
        // User can select exactly one txt file containing all data
        private string GetFile()
        {
            fileDialog.Title = "Please select a .txt file";
            fileDialog.Filter = "Text|*txt";
            fileDialog.Multiselect = false;
            fileDialog.FilterIndex = 1;
            fileDialog.ShowDialog();

            return fileDialog.FileName;
        }

        // GetData(string path) Uses the path from GetFile() to read the txt-file
        // Returns a List with Tuples containing the start and end of the interval
        private List<Tuple<int, int>> GetData(string path)
        {

            // lines = each line in the text document
            // data  = List of tuples<int, int> where data is stored, since there are always two digits within one intervall
            var lines = File.ReadAllLines(path);
            List<Tuple<int, int>> data = new List<Tuple<int, int>>();

            try
            {
                // Iterate through the lines of data
                foreach (var line in lines)
                {
                    // Split line into parts which' result look like this: [1,2] > "1,2"
                    var parts = line.Split(new char[] { ']', '[' }, StringSplitOptions.RemoveEmptyEntries);

                    // Iterate through the parts and try to parse the content to Integer
                    foreach (var part in parts)
                    {
                        // To save the status of the parse, if it was successful or not
                        bool first = Int32.TryParse(part.Split(',')[0], out int minInt);
                        bool second = Int32.TryParse(part.Split(',')[1], out int maxInt);

                        // Check if both were successful: If not, skip this "part" and continue
                        if (first && second)
                        {
                            // Change order if minInt is bigger then maxInt
                            if (minInt > maxInt)
                            {
                                var temp = minInt;
                                minInt = maxInt;
                                maxInt = temp;
                            }

                            // Add both values into the data list as a Tuple
                            data.Add(new Tuple<int, int>(minInt, maxInt));
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                return data;
            }
            catch
            {
                // Display a message after an error
                MessageBox.Show("Error occured!\nPlease make sure you've selected the correct file", "Error");
                return null;
            }
        }

        // Iterates through the data and compares start and end values of the interval
        // Merges two intervals together (if necessary) and then returns a List<Tuple<int, int>> with results
        private List<Tuple<int, int>> CalculateIntervall(List<Tuple<int, int>> data)
        {
            // Results are stored inside of this List
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            // tempUsedOnes stores all intervals which already was merged, so it can skip these
            List<Tuple<int, int>> tempUsedOnes = new List<Tuple<int, int>>();

            // Iterate through data and temporarily save the current min and max value out of the current entry
            foreach (var entry in data)
            {
                int minInt = entry.Item1;
                int maxInt = entry.Item2;

                // Check if entry is already merged or not, if so skip
                if (tempUsedOnes.Contains(entry)) continue;

                // Iterate through the data again to compare values
                foreach (var compareEntry in data)
                {
                    /*
                     * If the first bool-statement ((x) && (y)) is true then the start value of compareEntry (Item1) is within the interval
                     * If the second bool-statement is true then the end value of compareEntry (Item2) is within the interval
                     * 
                     * In this example you can see that both (b) and (c) are within the interval the only difference between (b) and (c)
                     * is that the '6' is in a different place. The first bool-statement checks if the first value of compareEntry overlaps
                     * the current interval and the second one does the same with the second value.
                     * 
                     * Example: (a) = [5,7] ; (b) = [4,6]; (c) = [6,9]
                     *
                     *           (a)|-------|
                     *       (b)|------|
                     *              (c)|-------|
                     */
                    if (((compareEntry.Item1 >= minInt) && (compareEntry.Item1 <= maxInt)) || ((compareEntry.Item2 >= minInt) && (compareEntry.Item2 <= maxInt)))
                    {
                        // Change start and end of interval when value is smaller then min or greater then max
                        if (!(minInt <= compareEntry.Item1)) minInt = compareEntry.Item1;
                        if (!(maxInt >= compareEntry.Item2)) maxInt = compareEntry.Item2;
                        
                        // Add used entry into list
                        tempUsedOnes.Add(compareEntry);
                    }
                }

                // Add merged minInt and maxInt after compare loop
                result.Add(new Tuple<int, int>(minInt, maxInt));
            }

            return result;
        }

    }
}
