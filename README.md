
# BestCloudAcademy-API-Case

## Genel Bakış
Bu proje, C# ve .NET 8.0 kullanılarak geliştirilmiş basit bir API'yi kapsar. API, Docker kullanılarak containerize edilmiştir ve bir Kubernetes kümesine dağıtılmıştır. API, sağlık kontrolü yapar, GET ve POST isteklerini işler ve dışarıya bir URL üzerinden erişilebilir.

## Özellikler
- **GET /**: `{"msg":"BC4M"}` cevabını döner.
- **GET /health**: API'nin sağlık durumunu döner.
- **POST /**: Gönderilen veriyi geri döner.


##Demo
https://365c-37-130-122-164.ngrok-free.app/

## Docker Kurulumu
1. **Docker İmajını Oluşturun**:
   ```bash
   docker build -t meassess/myapi .
   ```
2. **Docker Konteynerini Çalıştırın**:
   ```bash
   docker run -d -p 8080:80 --name myapi-container myapi
   ```
3. **Docker Hub’a Yükleyin**:
   ```bash
   docker push meassess/myapi
   ```

## Kubernetes Dağıtımı
1. **Minikube'u Başlatın**:
   ```bash
   minikube start
   ```
2. **Uygulamayı Dağıtın**:
   ```bash
   kubectl apply -f deployment.yaml
   kubectl apply -f service.yaml
   ```
3. **Dağıtımı Kontrol Edin**:
   ```bash
   kubectl get pods
   kubectl get services
   ```

## Dışarıdan Erişim
- **ngrok**: Servisi dışarıya açmak için ngrok kullanıldı.
   ```bash
   ngrok http 127.0.0.1:14400
   ```


## Repository İçeriği
- **Dockerfile**: API'nin containerize edilmesi için yapılandırma dosyası.
- **deployment.yaml**: Kubernetes deployment yapılandırma dosyası.
- **service.yaml**: Kubernetes service yapılandırma dosyası.

## Ek Bilgiler
- Docker Hub İmajı: [meassess/myapi](https://hub.docker.com/r/meassess/myapi)
- Kubernetes Cluster: Minikube kullanılarak bir LoadBalancer servisi ile dağıtıldı.

## Lisans
Bu proje MIT Lisansı altında açık kaynaklıdır.
