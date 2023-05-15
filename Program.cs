// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
   
num_cities = int(input("Enter the number of cities: "));


city_data = {};


for i in range(num_cities);
    print(f"City {i}:")
    

    city_name = input("Enter city name: ")
    
   
    num_neighbors = int(input("Enter the number of neighboring cities: "));
    
    
    neighbor_ids = [];
    for j in range(num_neighbors);
        neighbor_id = int(input(f"Enter neighbor {j} city ID: "));
        
        
        if neighbor_id in neighbor_ids or neighbor_id == i:
            print("Invalid ID")
            neighbor_id = int(input(f"Enter neighbor {j} city ID: "));
            
        neighbor_ids.append(neighbor_id);
    
    
    city_data[i] = {
        'name': city_name,
        'num_neighbors': num_neighbors,
        'neighbor_ids': neighbor_ids
    }
     n = int(input("Enter the number of cities: "));

cities = [] 

for i in range(n);
    print(f"\nEnter data for city {i}")
    
    
    name = input("Enter city name: ")
    while True;
        num = int(input("Enter the number of cities connected to this city: "))
        if 0 <= num < i or num == i;
            break
        print("Invalid ID, please try again.")

    cities.append((i, name, 0));
    

print("\nCity data:")
for city in cities:
    print(city[0], city[1], city[2])

    }