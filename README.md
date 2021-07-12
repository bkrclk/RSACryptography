Sertifika oluşturma işlemi için gerekli olan bazı yöntemler vardır bunlardan biride bizim kullanmış olduğumuz OpenSSL kütüphanesidir
ilk önce https://sourceforge.net/projects/gnuwin32/ adresine gidip yardımcı porgramı indirebilirsiniz

Ardından dosya dizini içersinde aşağıdaki komutları girip public/private keyler oluşturulur.

genrsa -out privateKey.pem 2048\
![Screenshot_1](https://user-images.githubusercontent.com/54475720/125290516-1034eb80-e329-11eb-87d9-cde9e22c98e3.png)

rsa -in privateKey.pem -pubout -out publicKey.pem\
![Screenshot_2](https://user-images.githubusercontent.com/54475720/125290532-14f99f80-e329-11eb-8453-277f0db0aae8.png)
