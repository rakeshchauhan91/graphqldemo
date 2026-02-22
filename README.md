# graphqldemo

##GraphQL: A History
GraphQL is an open source query language created by Facebook. Before GraphQL went open source in 2015, Facebook had used it internally for their mobile applications since 2012 as an alternative to the common REST architecture. As a result, network usage was reduced dramatically for Facebook’s mobile applications because GraphQL made it more efficient with data transfers.

Let’s say you want to fetch data from the Rest API and you say, “Hey REST API, give me the titles of the available courses on Educative”. How this works is that you have a specific endpoint or URL (in our case, Educative) that you are hitting and that URL determines what data comes back. With the REST API, you fetch a URL and that URL is returning typically something like JSON or a Javascript object full of data. This results in either unwanted data that we must filter through to fetch our required data or multiple trips (requests) to cater to different queries. However, GraphQL is different.

##How is GraphQL Different?
Instead of an API where you hit a URL and accept whatever data comes back, GraphQL allows you to ask for specific data, giving clients more control over what information is sent.

##The Sandwich Comparison
Think of it like this; you want a sandwich with only bread, cheese, cucumbers, and lettuce. You walk into a RESTaurant where the only option on the menu is ‘sandwich’; you place an order and receive a sandwich with bread, salami, lettuce, tomatoes, cucumbers, and cheese. You then remove everything you don’t want, to be able to eat the sandwich you wanted; this is how the REST API works. However, when you visit GraphQL cafe, you realize you can specify which toppings you want in your sandwich and receive exactly what you wanted.
