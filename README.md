# DataDome ASP .NET Core demo

This repository provides an example of the DataDome ASP .NET Core module using Docker.

For additional information, please check our [public documentation](https://docs.datadome.co/docs/aspnet-core).

## 1 - Configuration

Define the following ENV variables 
Set your `datadome-server-side-key` (found inside your [DataDome Dashboard](https://app.datadome.co/dashboard/management/integrations)).

```
export DATADOME_SERVER_SIDE_KEY=datadome-server-side-key
export DATADOME_TIMEOUT=300
export DATADOME_ENDPOINT=api.datadome.co
export DATADOME_PROTOCOL=https
```

## 2 - Build

```
docker build -t datadome-dotnetcore-image ./
```

## 3 - Run

```
docker run -dit --name datadome-dotnetcore-container -p 8080:80 \
-e DataDomeConfiguration:LicenseKey=${DATADOME_SERVER_SIDE_KEY} \
-e DataDomeConfiguration:Timeout=${DATADOME_TIMEOUT} \
-e DataDomeConfiguration:ApiDomain=${DATADOME_ENDPOINT} \
-e DataDomeConfiguration:ApiProtocol=${DATADOME_PROTOCOL} \
datadome-dotnetcore-image
```

## 4 - Test

```
curl -v  http://localhost:8080/
```

Your request was protected (the header `X-DataDome: protected` is present) and is shown in your Dashboard.

## 5 - Logs

```
docker logs -f datadome-dotnetcore-demo-container
```

## 6 - Stop

```
docker stop  datadome-dotnetcore-demo-container
```
