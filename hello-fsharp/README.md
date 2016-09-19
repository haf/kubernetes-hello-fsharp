```
docker build -t gcr.io/$PROJECT_ID/hello-fsharp:v1 .
docker run -d -p 8080:8080 --name hello_tutorial gcr.io/$PROJECT_ID/hello-fsharp:v1
curl "http://$(docker-machine ip default):8080"
docker stop hello_tutorial
gcloud docker push gcr.io/$PROJECT_ID/hello-fsharp:v1
```
