# graphqldemo

# GraphQL: A History
GraphQL is an open source query language created by Facebook. Before GraphQL went open source in 2015, Facebook had used it internally for their mobile applications since 2012 as an alternative to the common REST architecture. As a result, network usage was reduced dramatically for Facebook’s mobile applications because GraphQL made it more efficient with data transfers.

Let’s say you want to fetch data from the Rest API and you say, “Hey REST API, give me the titles of the available courses on Educative”. How this works is that you have a specific endpoint or URL (in our case, Educative) that you are hitting and that URL determines what data comes back. With the REST API, you fetch a URL and that URL is returning typically something like JSON or a Javascript object full of data. This results in either unwanted data that we must filter through to fetch our required data or multiple trips (requests) to cater to different queries. However, GraphQL is different.

# How is GraphQL Different?
Instead of an API where you hit a URL and accept whatever data comes back, GraphQL allows you to ask for specific data, giving clients more control over what information is sent.

# The Sandwich Comparison
you want a sandwich with only bread, cheese,  and lettuce. You walk into a RESTaurant where the only option on the menu is ‘sandwich’; you place an order and receive a sandwich with bread, salami, lettuce, tomatoes, cucumbers, and cheese. You then remove everything you don’t want, to be able to eat the sandwich you wanted; this is how the REST API works. However, when you visit GraphQL cafe, you realize you can specify which toppings you want in your sandwich and receive exactly what you wanted.

# Specification…NOT Implementation
GraphQL is a query language, it is a way to get data from an API to your application hence, it is a specification rather than an implementation. Initially, Facebook open-sourced the GraphQL specification and its reference implementation in JavaScript. Now, along with Javascript, several libraries have been incorporated in implementation.

Currently, GraphQL operations can be divided into two broad categories, a query (read) and mutation (write). Each of these operations is only a string that needs to be constructed according to the GraphQL query language specification. Graphql has spec to query data when it reaches backend its evaluated with the Graphql schema created and data is prepared for response.

GraphQL’s unique data retrieval method works by giving you control over the data you receive instead of the server; this way, the results are more predictable. This is possible through four key components of GraphQL—schemas, queries, resolvers, and mutations:

* Schema: Schemas show you exactly what data you can query, what operations the API can use, the relationships between the data, and their characteristics. 

* Query: Queries are requests to the server for data retrieval that contain information on the type of data you want to receive. 

* Resolver: Resolvers can retrieve data from any source and supply the instructions for transforming a query into data.

*  Mutation: Mutations help you to update and modify server-side data. You define mutations within the schema to specify the type of change you want to make, such as deleting or creating new data.


# Implementation:
.net 8 core with clean architecture
hotchoclate aspnet core library

# Hot Chocolate is an open-source GraphQL server for the Microsoft .NET platform that is compliant with the newest GraphQL October 2021 spec + Drafts, which makes Hot Chocolate compatible to all GraphQL compliant clients like Strawberry Shake, Relay, Apollo Client, and various other GraphQL clients and tools.
