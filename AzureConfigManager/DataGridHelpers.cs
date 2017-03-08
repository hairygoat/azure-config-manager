using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AzureConfigManager
{
    public static class DataGridHelpers
    {
        public static List<Setting> SettingsFromDataGrid(DataGridView grid)
        {
            return SettingsFromDataGridRows(grid.Rows.OfType<DataGridViewRow>());
        }

        public static List<Setting> SettingsFromDataGridRows(IEnumerable<DataGridViewRow> dataGrid)
        {
            var settings = new List<Setting>();
            foreach (var row in dataGrid)
            {
                var rowArray = row.Cells;
                if (rowArray[0].Value == null || rowArray[1].Value == null)
                {
                    // No data in row
                    continue;
                }

                if (rowArray.Count == 3)
                {
                    settings.Add(new Setting
                    {
                        Key = rowArray[0].Value.ToString(),
                        Value = rowArray[1].Value.ToString(),
                        IsSql = (bool)(rowArray[2]?.Value ?? false)
                    });
                }
                else
                {
                    settings.Add(new Setting
                    {
                        Key = rowArray[0].Value.ToString(),
                        Value = rowArray[1].Value.ToString(),
                        IsSql = false
                    });
                }
            }
            return settings.OrderBy(s => s.Key).ToList();
        }

        public static Dictionary<string, string> DataGridToDictionary(DataGridView grid)
        {
            return grid.Rows
                       .OfType<DataGridViewRow>()
                       .Where(r => r.Cells[0].Value != null && r.Cells[1].Value != null)
                       .ToDictionary(r => r.Cells[0].Value.ToString(), r => r.Cells[1].Value.ToString());
        }

        public static void FillDataGridFromDictionary(DataGridView grid, Dictionary<string, string> dictionary)
        {
            grid.Rows.Clear();
            foreach (var entry in dictionary)
            {
                grid.Rows.Add(entry.Key, entry.Value);
            }
        }
    }
}
