# azure-resume
my own resume on azure following [https://www.youtube.com/watch?v=ieYrBWmkfno&amp;ab_channel=ACloudGuru]


## First steps
- Frontend folder contains the website
- main.js contains visitor counter code

```js
//to save and push to a github
git add -A // save changes you've made
git commit -m "updates to readme" // commit changes with message
git push  // push to github
```

## Section 2: Building the backend
## 1. Setting up CosmosDB resources

create cosmosDB account, database, container and data

## 2 Setting up Azure Function
Create azure function that will interact with Cosmos DB counter data

## 3. Test Locally
make sure we can view counter data in the browser in our website locally

## Section 3
1. Deploy to Azure Function
    deploy our Azure Function to Azure, grab it's URL and update our JavaScript code with it.
2. Deploy to Blob Container
    deploy our static site to out blob container.
3. setup Azure CDN for HTTPS and custom domain support
