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
                    Name = "Tên",
                    Width = 50
                },
                new ColumnObject
                {
                    Name = "Họ",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Ngày sinh",
                    Width = 150
                },
                new ColumnObject
                {
                    Name = "SĐT",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Giới tính",
                    Width = 90
                },
                new ColumnObject{
                    Name = "Giới tính",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "CCCD",
                    Width = 150
                },
                new ColumnObject
                {
                    Name = "Vị trí",
                    Width = 150
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
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Deleted",
                    Width = 50
                },
                new ColumnObject
                {
                    Name = "URL",
                    Width = 200
                },
            };
        public static ColumnObject[] PRODUCT_COLS = {
                new ColumnObject
                {
                    Name = "Tên sản phẩm",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Serial",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Product price",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Sale price",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Số lượng",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Trạng thái",
                    Width = 200
                },
                 new ColumnObject
                {
                    Name = "Deleted",
                    Width = 100
                }
            };
        public static ColumnObject[] CUSTOMERS_COLS = {
                new ColumnObject
                {
                    Name = "Mã khách hàng",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Tên",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Họ",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Ngày sinh",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "SĐT",
                    Width = 250,
                },
                 new ColumnObject
                {
                    Name = "Giới tính",
                    Width = 90
                },
                 new ColumnObject
                {
                    Name = "Giới tính",
                    Width = 90
                },
                new ColumnObject
                {
                    Name = "CCCD",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Email",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Địa chỉ",
                    Width = 200
                },          
                new ColumnObject
                {
                    Name = "Deleted",
                    Width = 100
                }
            };
        public static ColumnObject[] PURCHASEINVOICES_COLS = {
                new ColumnObject
                {
                    Name = "Mã hóa đơn nhập",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Mã nhà cung cấp",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Mã sản phẩm",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Ngày nhập",
                    Width = 250
                },
                 new ColumnObject
                {
                    Name = "Số lượng",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Trạng thái",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Deleted",
                    Width = 100
                }
            };
        public static ColumnObject[] SALEINVOICES_COLS = {
                new ColumnObject
                {
                    Name = "Mã hóa đơn bán",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Mã khách hàng",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Mã nhân viên",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Mã sản phẩm",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Ngày nhập",
                    Width = 250
                },
                 new ColumnObject
                {
                    Name = "Số lượng",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Trạng thái",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Deleted",
                    Width = 100
                }
            };
        public static ColumnObject[] SALETARGETS_COLS = {
                new ColumnObject
                {
                    Name = "Mã bán hàng",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Mã nhân viên",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Ngày bắt đầu",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Ngày kết thúc",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Tổng",
                    Width = 100
                },
                 new ColumnObject
                {
                    Name = "Mục tiêu",
                    Width = 100
                },
                new ColumnObject
                {
                    Name = "Trạng thái",
                    Width = 200
                },
                new ColumnObject
                {
                    Name = "Hoa hồng",
                    Width = 50
                }
            };
        public static ColumnObject[] DEVICES_COLS =
        {
            new ColumnObject
                {
                    Name = "Mã thiết bị",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Tên thiết bị",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Ngày hết hạn",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Giá",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Trạng thái",
                    Width = 200
                }
        };
        public static ColumnObject[] TESTDRIVE_COLS =
        {
            new ColumnObject
                {
                    Name = "Mã lái xe",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Mã nhân viên",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Mã khách hàng",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Ngày đặt",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Ghi chú",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Trạng thái",
                    Width = 200
                }
        };
        public static ColumnObject[] ACCOUNT_COLS =
        {
            new ColumnObject
                {
                    Name = "Mã nhân viên",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Tên người dùng",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Mật khẩu",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Cấp độ tài khoản",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Deleted",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Ngày tạo",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Ngày xóa",
                    Width = 200
                }
        };
        public static ColumnObject[] SOURCE_COLS =
        {
            new ColumnObject
                {
                    Name = "Mã nguồn cung cấp",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Tên nguồn cung cấp",
                    Width = 200
                }
        };
        public static ColumnObject[] PRODUCT_IMAGES_COLS =
        {
            new ColumnObject
                {
                    Name = "Serial",
                    Width = 200
                },
            new ColumnObject
                {
                    Name = "Đường dẫn ảnh",
                    Width = 200
                }
        };
    }
}
