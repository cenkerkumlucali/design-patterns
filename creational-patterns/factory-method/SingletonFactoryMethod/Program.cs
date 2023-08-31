﻿
using Practice.Concrete;
using Practice.Factory.Concrete;

BankCreator bankCreator = new();
GarantiBank? garanti = bankCreator.Create(BankType.Garanti) as GarantiBank;
HalkBank? halkBank = bankCreator.Create(BankType.Halkbank) as HalkBank;
VakifBank? vakifbank = bankCreator.Create(BankType.Vakifbank) as VakifBank;

GarantiBank? garanti2 = bankCreator.Create(BankType.Garanti) as GarantiBank;
HalkBank? halkBank2 = bankCreator.Create(BankType.Halkbank) as HalkBank;
VakifBank? vakifbank2 = bankCreator.Create(BankType.Vakifbank) as VakifBank;

GarantiBank? garanti3 = bankCreator.Create(BankType.Garanti) as GarantiBank;
HalkBank? halkBank3 = bankCreator.Create(BankType.Halkbank) as HalkBank;
VakifBank? vakifbank3 = bankCreator.Create(BankType.Vakifbank) as VakifBank;

