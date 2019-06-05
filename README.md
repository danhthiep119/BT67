# BT67
Xây dựng menu chương trình như sau

1. Nhập thông tin khách sạn

2. Hiển thị thông tin khách sạn

3. Đặt phong nghỉ

4. Tìm phòng còn trống

5. Thống kê doanh duy khách sạn

6. Tìm kiếm thông tin khách hàng.

7. Thoát chương trình

Yêu cầu :

1. Thiết kế lớp đối tượng khách hàng gồm các thuộc tính (Số CMTND, họ tên, tuổi, giới tính, quê quán)

- Thiết kế get/set cho thuộc tính

- Tạo hàm tạo ko đối và đầy đủ đối số

- Tạo hàm nhập và hiển thị thông tin

2. Thiết kế lớp Hotel gồm các thuộc tính : tên, địa chỉ, loại khách sạn (VIP, Bình dân,...), danh sách các Room, mã khách sạn


- Thiết kế get/set cho thuộc tính

- Tạo hàm tạo ko đối và đầy đủ đối số

- Tạo hàm nhập và hiển thị thông tin

3. Thiết kế lớp Room gồm các thuộc tính : Tên phòng, giá tiền, tầng, số người tối đa ở, mã phòng

- Thiết kế get/set cho thuộc tính

- Tạo hàm tạo ko đối và đầy đủ đối số

- Tạo hàm nhập và hiển thị thông tin

4. Thiết kế lớp Book gồm các thuộc tính : ngày book, ngày trả phòng, Số CMTND người book, mã khách sạn, mã phòng

Chú ý : Số CMTND -> nếu chưa tồn tại -> nhập thông tin KH đó

Mã khách sạn -> Nếu ko tồn tại, yêu cầu nhập đúng khách sạn đã có

Mã Phòng -> yêu cầu nhập đúng mã phòng của KH mà người dùng muốn book -> Nếu nhập sai, yêu cầu nhập đúng mới dừng.

Chú thích menu :

Khi người dùng chọn 1 : Hỏi người dùng số khách sạn cần nhập => Khi nhập mỗi khách sạn thì yêu cầu

- Nhập thông tin khách sạn đó

- Hỏi người dùng nhập số phòng cần nhập cho khách sạn đó => Nhập thông tin từng phòng

Khi người dùng chọn 2 : In toàn bộ thông tin liên quan tới KS

Khi người dùng chọn 3 : Nhập thông tin đặt phòng (Book)

Khi người dùng chọn 4: Nhập vào 1 ngày book và ngày trả phòng, in ra tất cả các phòng có thể đap ứng đc yêu cầu trên

Khi người dùng chọn 5 : In ra tổng tiền mà mỗi khách sạn kiếm được ra màn hình.

Khi người dùng chọn 6 : Nhập Số CMTND khách hàng => In ra tất cả các khách sạn mà khách hàng này đã tới.

Khi người dùng chọn 7 : Thoát chương trình.

