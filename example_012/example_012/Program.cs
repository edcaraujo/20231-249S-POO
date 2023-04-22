// See https://aka.ms/new-console-template for more information
using example_012;



CargoDB cargoDB = new CargoDB(new MysqlDB());

Cargo c = new Cargo();
c.Name = "Pintor";

cargoDB.insert(c);



