using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData.Util
{
    public class ColumnObject
    {
        public string Name { get; set; } = "";
        public int Width { get; set; }  
 
        public static ColumnObject[] EMPLOYEES_COLS = {
                new ColumnObject
                {
                    Name = "Mã nhân viên",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Họ",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Tên",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Ngày sinh",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "CCCD",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Vị trí",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Ngày bắt đầu",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Lương",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Email",
                    Width = 100
                }
            };
        public static ColumnObject[] PRODUCT_COLS = {
                new ColumnObject
                {
                    Name = "Mã nhân viên",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Họ",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Tên",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Ngày sinh",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "CCCD",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Vị trí",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Ngày bắt đầu",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Lương",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Email",
                    Width = 100
                }
            };
    }
}
