# Simple Nancy App

A bare-bones, self-hosting Nancy app with instructions for Heroku deployment.
All of the heavy lifting was done by [Ben Hall](https://github.com/BenHall); the
goal of this fork is simply to collect and document Ben's hard work to make
simple C# apps on Heroku easier to create.

## Dependencies

First, you'll need to create a Heroku account and install the [Heroku toolbelt](https://toolbelt.heroku.com/).

## Creating a New Heroku App

When you create a new Heroku app, Heroku automatically assigns you a
hostname for your app. In the example below, the hostname is
`stark-hollows-8350.herokuapp.com`. You need to save this hostname in an
environment variable named `HOST` for the Nancy app to bind to the
correct Uri; *do not* just copy-paste the source below–you must specify
your unique host.

```shell
$ heroku create --stack cedar --buildpack http://github.com/BenHall/heroku-buildpack-mono
$ heroku config:set HOST=stark-hollows-8350.herokuapp.com
$ git push heroku master
```

## Building Locally

Before deploying your source code you will need to ensure that it builds locally. For example:

```shell
$ xbuild Nancy.Demo.Hosting.Self.sln
```

## Running Locally

To test running your application locally, execute the following:

```shell
$ foreman start local
```
