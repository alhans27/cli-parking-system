# EXAMPLE COMMAND

### Create Parking Lot
```
$ create_parking_lot 6
```
Result:  
> Created a parking lot with 6 slots

### Park a Vehicle
```
$ park B-1234-XYZ Putih Mobil
```
Result:  
> Allocated slot number: 1

```
$ park B-9999-XYZ Putih Motor
```
Result:  
> Allocated slot number: 2

```
$ park D-0001-HIJ Hitam Mobil
```
Result:  
> Allocated slot number: 3

```
$ park B-7777-DEF Red Mobil
```
Result:  
> Allocated slot number: 4

```
$ park B-2701-XXX Biru Mobil
```
Result:  
> Allocated slot number: 5

```
$ park B-3141-ZZZ Hitam Motor
```
Result:  
> Allocated slot number: 6

### Leave Vehicle From the Parking Lot
```
$ leave 4
```
Result:  
> Slot number 4 is free

### Check Status Parking Area
```
$ status
```
Result:  
> 1 =>  B-1234-XYZ	Mobil	Putih 18/04/2024 12:23:44  
> 2 =>	B-9999-XYZ	Motor	Putih 18/04/2024 12:23:46  
> 3 =>	D-0001-HIJ 	Mobil	Hitam 18/04/2024 12:23:48  
> 4 =>  NULL  
> 5 =>	B-2701-XXX 	Mobil	Biru 18/04/2024 12:23:50  
> 6 =>	B-3141-ZZZ 	Motor	Hitam 18/04/2024 12:23:52  

### Park a Vehicle in an Empty Lot
```
$ park B-333-SSS Putih Mobil
```
Result:  
> Allocated slot number: 4

### Parking Over Lot
```
$ park A-1212-GGG Putih Mobil
```
Result:  
> Sorry, parking lot is full

### Counting the Number of Motorcycle Type Vehicles
```
$ type_of_vehicles Motor
```
Result:  
> 2

### Counting the Number of Car Type Vehicles
```
$ type_of_vehicles Mobil
```
Result:  
> 4

### OOD Plate
```
$ registration_numbers_for_vehicles_with_ood_plate
```
Result:  
> B-9999-XYZ, D-0001-HIJ, B-2701-XXX,

### EVEN Plate
```
$ registration_numbers_for_vehicles_with_event_plate
```
Result:  
> B-1234-XYZ, B-3141-ZZZ,

### Vehicle Plates Based on Vehicle Color
```
$ registration_numbers_for_vehicles_with_colour Putih
```
Result:  
> B-1234-XYZ, B-9999-XYZ, B-333-SSS,

### Slot Parking Based on Vehicle Color
```
$ slot_numbers_for_vehicles_with_colour Putih
```
Result:  
> 1, 2, 4,

### Slot Parking Based on Vehicle Plates
```
$ slot_number_for_registration_number B-3141-ZZZ
```
Result:  
> 6

### Slot Parking Based on Vehicle Plates When Not Found
```
$ slot_number_for_registration_number Z-1111-AAA
```
Result:  
> Not found

### Close the App
```
$ exit
```
Result:  
> ==exit command is running==
