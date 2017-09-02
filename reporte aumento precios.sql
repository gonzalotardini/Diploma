


Select ((Select top 1 precio from MovimientoPrecios 
where Cod_Articulo=3301
 order by Fecha desc) / 
 (Select top 1 ( precio) from MovimientoPrecios 
where Cod_Articulo=3301
 order by Fecha ) -1) *100 as 'Porcentaje', COUNT(Precio) as 'Cantidad de Precios'
 from MovimientoPrecios where Cod_Articulo=3301 


 


