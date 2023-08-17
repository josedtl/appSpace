import os

def generate_class_from_sqlStore(attributesData:[],NameTable, output_path):
    # script = re.sub(r'\([^)]*\)', '', script)
    attributes =[]
    first_attribute_name = ""
    
    for line in attributesData:
        java_attribute_type = line['type']
        attribute_name =line['name']
        attributes.append({"name": attribute_name, "type": java_attribute_type})

    first_attribute_name = attributes[0]['name']
    
    class_name = first_attribute_name.replace("Id", "") 
    
    class_code = f"CREATE PROCEDURE sp_{class_name}AllItems()\n"
    class_code += "BEGIN\n"
    class_code += "  SELECT\n"
    
    Cont = 1
    for attribute in attributes:
        attribute_name = attribute["name"]
        java_attribute_name = attribute_name[0].lower() + attribute_name[1:]  # Primera letra en minúscula
        attribute_type = attribute["type"]
        if Cont == len(attributes):
            class_code += f"    {attribute_name}\n"
        else:
            class_code += f"    {attribute_name},\n"
        Cont = Cont + 1

    class_code += f"  FROM {NameTable};\n"
    class_code += f"END;\n\n"


    class_code = f"CREATE PROCEDURE sp_{class_name}AllItem(IN v_{class_name} INT)\n"
    class_code += "BEGIN\n"
    class_code += "  SELECT\n"
    
    for attribute in attributes:
        attribute_name = attribute["name"]
        java_attribute_name = attribute_name[0].lower() + attribute_name[1:]  # Primera letra en minúscula
        attribute_type = attribute["type"]

        class_code += f"    {attribute_name},\n"

        
    
    class_code += f"  FROM {NameTable} WHERE  {class_name}Id = v_{class_name}Id;\n"
    class_code += f"END;\n\n"

    class_code += f"CREATE PROCEDURE sp_{class_name}_Save(\n"

    for attribute in attributes:
        attribute_name = attribute["name"]
        attribute_type = attribute["type"]
        class_code += f"    IN v_{attribute_name} {attribute_type},\n"

    class_code += f")\n"
    class_code += f"BEGIN\n"
    class_code += f"    INSERT INTO {NameTable} (\n"
    for attribute in attributes:
        attribute_name = attribute["name"]
        attribute_type = attribute["type"]
        class_code += f"        v_{attribute_name},\n"


    class_code += f") VALUES (\n"
    for attribute in attributes:
        attribute_name = attribute["name"]
        attribute_type = attribute["type"]
        class_code += f"        v_{attribute_name},\n"
    class_code += f"    );\n\n"
    class_code += f"  SET v_{class_name}Id = LAST_INSERT_ID();\n\n"
    class_code += f"END;\n\n"   


    class_code += f"CREATE PROCEDURE sp_{class_name}_Update(\n"

    for attribute in attributes:
        attribute_name = attribute["name"]
        attribute_type = attribute["type"]
        class_code += f"    IN v_{attribute_name} {attribute_type},\n"

    class_code += f")\n"
    class_code += f"BEGIN\n"
    class_code += f"    UPDATE {NameTable}\n"
    class_code += f"    SET\n"
    
    for attribute in attributes:
        attribute_name = attribute["name"]
        attribute_type = attribute["type"]
        class_code += f"        {attribute_name} = v_{attribute_name},\n"
    class_code += f"    WHERE\n"
    class_code += f"        {class_name}Id = v_{class_name}Id;\n"
    class_code += f"END;\n\n"   

    class_code += f"CREATE  PROCEDURE `sp_{class_name}Delete`(IN v_{class_name}Id int)\n"   
    class_code += f"BEGIN\n" 
    class_code += f"  DELETE\n" 
    class_code += f"    FROM {NameTable}\n" 
    class_code += f"  WHERE {class_name}Id = v_{class_name}Id;\n" 
    class_code += f"  END;\n" 

    output_file = os.path.join(output_path, f"{class_name}.sql")
    with open(output_file, "w") as java_file:
        java_file.write(class_code)
