# Simple Nancy App

A bare-bones, self-hosting Nancy app with instructions for Heroku deployment.
All of the heavy lifting was done by [Ben Hall](https://github.com/BenHall); the
goal of this fork is simply to collect and document Ben's hard work to make
simple C# apps on Heroku easier to create.

## Dependencies

First, you'll need to create a Heroku account and install the [Heroku toolbelt](https://toolbelt.heroku.com/).

## Creating a New Heroku App

To build and run your app locally, just do:

```shell
$ rake
```

To create a new Heroku app, deploy your app to Heroku, and open it in
your browser, simply do:

```shell
$ rake init
```

You should only run `rake init` once.  When Heroku creates a new app, it
assigns a unique hostname to your app,
`stark-hollows-8350.herokuapp.com` for example.  You need to save this
hostname in an environment variable named `HOST` for the Nancy app to
bind to the correct Uri. `rake init` does this step for you, but if you
ever change your Heroku host name, remember to update `HOST`:

```shell
$ heroku config:add HOST=<your new hostname>
```

## Building Locally

```shell
$ rake build
```

## Running Locally

```shell
$ rake stage # or just `rake`
```

## Deploying to Heroku

This is merely a shortcut for `git push heroku master`:

```shell
$ rake deploy
```
