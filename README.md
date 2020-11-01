# rfid_parking_system

Phần mềm dùng đầu đọc thẻ RFID READER 13.56 MHz.\
Vì không có raspberry nên phải chạy song song 2 solution nhé.\
Chạy solution MagtekCardReader để đọc thẻ từ.\
Bật chương trình chính để sử dụng.\
Database có tên parkingDatabase.sql.\
Lưu ý thay đổi đường dẫn trong frmAdmin.cs và frmTicketIn.cs của solution chính.\
2 đường dẫn được lưu mặc định:\
String location = @"C:\Users\\UwU\source\repos\Ticket\Ticket\note\reader.txt";\
string directory = @"C:\Users\UwU\source\repos\Ticket\Ticket\images\";\
Thay đổi đường dẫn trong Program.cs của solution MagtekCardReader.\
Đường dẫn được lưu mặc định:\
File.WriteAllText(@"C:\Users\UwU\source\repos\Ticket\Ticket\note\reader.txt", s);\
Tài khoản mặc định có tên đăng nhập và mật khẩu là admin.
