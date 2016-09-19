From http://kubernetes.io/docs/hellonode/


```
export PROJECT_ID="YOUR_PROJECT_NAME"
```

```
docker build -t gcr.io/$PROJECT_ID/hello-fsharp:v1 .
docker run -d -p 8080:8080 --name hello_tutorial gcr.io/$PROJECT_ID/hello-fsharp:v1
curl "http://$(docker-machine ip default):8080"
docker stop hello_tutorial
gcloud docker push gcr.io/$PROJECT_ID/hello-fsharp:v1
gcloud container clusters create hello-world
gcloud container clusters get-credentials hello-world
kubectl run hello-fsharp --image=gcr.io/$PROJECT_ID/hello-fsharp:v1 --port=8080
kubectl expose deployment hello-fsharp --type="LoadBalancer"
```

Make changes

```
docker build -t gcr.io/$PROJECT_ID/hello-fsharp:v2 .
gcloud docker push gcr.io/$PROJECT_ID/hello-fsharp:v2
kubectl set image deployment/hello-fsharp hello-fsharp=gcr.io/$PROJECT_ID/hello-fsharp:v2
kubectl get deployments
```

Watch control panel

```
kubectl proxy
start http://localhost:8001/
```

Then...

## \1. Continue...

```
http://kubernetes.io/docs/user-guide/quick-start/
```

## \2. Destroy

```
kubectl delete service,deployment hello-fsharp
gcloud container clusters delete hello-world
```

Remove images

```
gsutil ls
gsutil rm -r gs://artifacts.$PROJECT_ID.appspot.com/
```
