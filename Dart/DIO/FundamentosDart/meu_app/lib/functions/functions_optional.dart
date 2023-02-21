void main(List<String> arguments){
  printName("Leo");
  printName('Leonardo', lastname: "Martins");
}

void printName(String name, {String? lastname}){
  
  if(lastname != null){
    print("My name is $name $lastname");
  }else{
    print("My name is $name");
  }
}