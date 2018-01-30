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

# Game Console API

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

Gets a specific game console by its id.

**URL** : `/api/gameconsoles/:id`

**URL Parameters** : id=[Guid] where id is the ID of the game console on the server.

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

# Game API

## Get list of Games

Gets a list of all available games and/or filtered by console id.

**URL** : `/api/games?consoleId=(:consoleId)`

**URL Parameters** : consoleId=[Guid] where id is the ID of the game console on the server to filter the list with. **OPTIONAL**

**Method** : `GET`

**Auth required** : NO

**Permissions required** : None

### Success Response

**Code** : `200 OK`

**Content examples**

```json
[
    {
        "id": "707bf088-5aa4-4626-964e-5ea918ce3a54",
        "name": "Sonic",
        "description": "Kalle Kula",
        "consoleId": "01bbd4d6-85a1-4a5b-8f11-29d5fb321143"
    },
    {
        "id": "61e34ec1-5157-4597-9637-d7cbdcdfe547",
        "name": "Super Mario",
        "description": "Kalle Kula",
        "consoleId": "01bbd4d6-85a1-4a5b-8f11-29d5fb321143"
    },
    {
        "id": "1afcae27-8240-4219-82f3-e41385417f7a",
        "name": "Pokemon",
        "description": "Kalle Kula",
        "consoleId": "dc8ed7d5-344d-4d51-8b8a-4b8a10d94c3f"
    }
]
```

## Get game by id

Gets a game by its id.

**URL** : `/api/games/{id: Guid}`

**Method** : `GET`

**Auth required** : NO

**Permissions required** : None

### Success Response

**Code** : `200 OK`

**Content examples**

```json
{
    "id": "61e34ec1-5157-4597-9637-d7cbdcdfe547",
    "name": "Super Mario",
    "description": "Kalle Kula",
    "consoleId": "01bbd4d6-85a1-4a5b-8f11-29d5fb321143"
}
```