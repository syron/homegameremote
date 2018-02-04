# Homegameauto Client

## Prerequisites

* [NodeJS](https://nodejs.org/)
* [AngularCLI](https://cli.angular.io/)
* [Homegameauto API](https://github.com/syron/homegameremote/tree/master/server/homegameauto)

## Configuration

In src/environments/ you can find different environments files for the different environments.

Change the environment settings according to your specifications

```json
export const environment = {
  production: true,
  apiEndpoint: ""
};
```

The `apiEndpoint` needs to point to the actual web address of your deployed [Homegameauto API](https://github.com/syron/homegameremote/tree/master/server/homegameauto).

## Build

> All commands below need to be run in the same folder in which the .angular-cli.json file is.

Make sure, before building that you have installed all npm packages defined in the package.json, by running `npm install`

To run the app in debug, simply run `ng serve`

To actually build a production build run `ng build --prod`