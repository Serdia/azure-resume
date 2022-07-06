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

## Section 4 - Mapping custom domain
Caching is the process of storing copies of files in a cache, or temporary storage location, so that they can be accesses more quikly.
Purging is the process of removing cached contend and updating it before the preditermined expired date.

##  Building our CI/CD pipeline
1. Create frontene workflow
    create the GitHub workflow responsible for deploying the frontend of our project.
2. Implement unit testing
    create unit test to test our Azure Functions code as part of it's deployment workflow
3. Create backend workflow
    create the GitHub workflow responsible for deploying the backend of our project
