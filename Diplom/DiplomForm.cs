
using System.ComponentModel;

namespace Diplom
{
    public partial class DiplomForm : Form
    {
        public DiplomForm() => InitializeComponent();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dataGridViewStudentEntry.DataSource = StudentEntries;
            dataGridViewNumberEntry.DataSource = NumberEntries;

            localCalcNumberEntrySizes(dataGridViewNumberEntry, EventArgs.Empty);
            SizeChanged += localCalcNumberEntrySizes;

            void localCalcNumberEntrySizes(object? sender, EventArgs e)
            {
                var height = dataGridViewNumberEntry.Height / 2;
                var initialTotalWidth = Width * 2 / 3F;
                var width = (int)(Math.Max(20, initialTotalWidth / dataGridViewNumberEntry.Columns.Count));
                // Fix rounding errors
                var adjWidth = (width * dataGridViewNumberEntry.Columns.Count) / 2;
                tableLayoutPanel.ColumnStyles[2].Width = adjWidth;
                tableLayoutPanel.ColumnStyles[3].Width = adjWidth;

                var idCol = dataGridViewStudentEntry.Columns[nameof(StudentEntry.Id)];
                idCol.Width = labelCol1.Width + labelCol1.Margin.Horizontal - dataGridViewStudentEntry.RowHeadersWidth;
                idCol.DefaultCellStyle.Font = new Font(Font.FontFamily, 8f);
                dataGridViewStudentEntry.Columns[nameof(StudentEntry.Name)].Width =
                    labelCol2.Width + labelCol2.Margin.Horizontal + 1; // Where 1 is the width of the table layout panel cell border.

                dataGridViewNumberEntry.Rows[0].Height = height;
                dataGridViewNumberEntry.Rows[1].Height = height;
                dataGridViewNumberEntry.ScrollBars = ScrollBars.None;
                dataGridViewNumberEntry.Scroll += (sender, e)
                    => dataGridViewNumberEntry.FirstDisplayedScrollingRowIndex = 0;

                dataGridViewNumberEntry
                    .Columns.OfType<DataGridViewColumn>().ToList()
                   .ForEach(_ => _.Width = width);
                dataGridViewStudentEntry
                    .Columns.OfType<DataGridViewColumn>()
                    .Skip(2)
                    .ToList()
                   .ForEach(_ => _.Width = width);

                dataGridViewNumberEntry.Paint += (sender, e) =>
                {
                    // Customize this appearance.
                    for (int col = 0; col < dataGridViewNumberEntry.ColumnCount; col++)
                    {
                        var cell = dataGridViewNumberEntry.GetCellDisplayRectangle(col, 0, true);
                        var frame = new RectangleF(
                                x: cell.X,
                                y: e.Graphics.VisibleClipBounds.Top,
                                width: cell.Width,
                                height: e.Graphics.VisibleClipBounds.Height);
                        // Border
                        e.Graphics.DrawRectangle(Pens.Black, frame);
                        frame.Y += (frame.Height / 8) * 3;
                        frame.Height /= 4;
                        // Div
                        e.Graphics.DrawLine(Pens.Black, frame.Left, frame.Bottom, frame.Right, frame.Top);
                    }
                };
            }
        }

        BindingList<NumberEntry> NumberEntries { get; } = new BindingList<NumberEntry>
        {
            new NumberEntry
            {
                Column01 = 12,
                Column02 = 12,
            },
            new NumberEntry
            {
                Column01 = 12,
                Column02 = 45,
            },
        };
        BindingList<StudentEntry> StudentEntries { get; } = new BindingList<StudentEntry>
        {
            new StudentEntry
            {
                Name = "Tom Tester",
                Column02 = 3,
                Column05 = 3,
                Column07 = 3,
                Column08 = 3,
            },
            new StudentEntry{
                Name = "Vladimir Vapnik",
                Column02 = 5,
                Column05 = 5,
                Column07 = 5,
                Column08 = 5,
            },
        };
    }

    class StudentEntry : NumberEntry
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    class NumberEntry
    {
        public int Column01 { get; set; }
        public int Column02 { get; set; }
        public int Column03 { get; set; }
        public int Column04 { get; set; }
        public int Column05 { get; set; }
        public int Column06 { get; set; }
        public int Column07 { get; set; }
        public int Column08 { get; set; }
        public int Column09 { get; set; }
        public int Column10 { get; set; }
        public int Column11 { get; set; }
        public int Column12 { get; set; }
        public int Column13 { get; set; }
        public int Column14 { get; set; }
        public int Column15 { get; set; }
        public int Column16 { get; set; }
        public int Column17 { get; set; }
        public int Column18 { get; set; }
        public int Column19 { get; set; }
        public int Column20 { get; set; }
        public int Column21 { get; set; }
        public int Column22 { get; set; }
        public int Column23 { get; set; }
    }
}
