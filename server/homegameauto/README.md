# Home Game Automation Server Application

Server applications to start a console or emulator via mobile platform.

## Description

The server application is built with [ASP.Net Core](https://docs.microsoft.com/en-us/aspnet/core/).

## How-To's

### Run server app

```bash
cd homegameauto.api/
dotnet run
```

Navigate to url that is shown in your console.

# API

## Get list of consoles

Gets a list of all configures gaming consoles.

**URL** : `/api/gameconsoles/`

**Method** : `GET`

**Auth required** : NO

**Permissions required** : None

### Success Response

**Code** : `200 OK`

**Content examples**

```json
[
   {
      "id":"01bbd4d6-85a1-4a5b-8f11-29d5fb321143",
      "name":"XBox",
      "description":"Kalle kula....",
      "ipAddress":"192.168.0.1"
   },
   {
      "id":"d9bdbb8b-64b8-40bb-b3f9-8830acba6313",
      "name":"Playstation",
      "description":"Kalle kula....",
      "ipAddress":"192.168.0.2"
   },
   {
      "id":"dc8ed7d5-344d-4d51-8b8a-4b8a10d94c3f",
      "name":"Gameboy",
      "description":"Kalle kula....",
      "ipAddress":"192.168.0.3"
   }
]
```

## Get console by id

Gets a specific user by its id.

**URL** : `/api/gameconsoles/{id: Guid}`

**Method** : `GET`

**Auth required** : NO

**Permissions required** : None

### Success Response

**Code** : `200 OK`

**Content examples**

```json
{
    "id":"01bbd4d6-85a1-4a5b-8f11-29d5fb321143",
    "name":"XBox",
    "description":"Kalle kula....",
    "ipAddress":"192.168.0.1"
}
```