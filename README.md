Sertifika oluşturma işlemi için gerekli olan bazı yöntemler vardır bunlardan biride bizim kullanmış olduğumuz OpenSSL kütüphanesidir
ilk önce https://sourceforge.net/projects/gnuwin32/ adresine gidip yardımcı porgramı indirebilirsiniz

Ardından dosya dizini içersinde aşağıdaki komutları girip public/private keyler oluşturulur.\
**openssl**\
![Screenshot_3](https://user-images.githubusercontent.com/54475720/125471316-ad1b1d06-d14b-4f46-ad97-61cc4d018afd.png)

**genrsa -out privateKey.pem 2048**\
![Screenshot_1](https://user-images.githubusercontent.com/54475720/125290516-1034eb80-e329-11eb-87d9-cde9e22c98e3.png)

**rsa -in privateKey.pem -pubout -out publicKey.pem**\
![Screenshot_2](https://user-images.githubusercontent.com/54475720/125290532-14f99f80-e329-11eb-8453-277f0db0aae8.png)

NOT: Son commit içerisinde OpenSSL ile oluşturulan keylere gerek duyulmadan Enviromentta public-private keyler belirtilmiştir. OpenSSL ile key generate etme işlemi farklı bir tercih sebebi olabilir.



RSA şifrelemesi yalnızca küçük miktarlardaki veriler içindir, şifreleyebileceğiniz veri miktarı kullandığınız anahtarın boyutuna bağlıdır, 
1024 bit RSA anahtarları En fazla 117 bayt, 
2048 RSA anahtarı ile 245 baytı şifreleyebilirsiniz. 
4096 RSA anahtari için 383 baytı şifreleyebilirsiniz. 
Her karekter 1 byte olarak beliritilir
Bunun iyi bir nedeni var, asimetrik şifreleme hesaplama açısından pahalı. Büyük miktarda veriyi şifrelemek istiyorsanız simetrik şifreleme kullanmalısınız.
