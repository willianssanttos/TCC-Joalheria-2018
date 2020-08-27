CREATE trigger DecrementaEstoqueItensCompra on itenscompra
for delete 
as 
BEGIN
   DECLARE @qtde   float,
	@codigo         integer

	declare CURSOR_PROD cursor for

	select pro_cod, itc_qtde from deleted

	open CURSOR_PROD

	fetch next from CURSOR_PROD into @codigo, @qtde

	while @@FETCH_STATUS = 0
	begin

	update produto set pro_qtde = pro_qtde - @qtde where produto.pro_cod = @codigo
    
	fetch next from CURSOR_PROD into @codigo, @qtde

end
    
	 close CURSOR_PROD
	 deallocate CURSOR_PROD
end
go

CREATE trigger IncrementaEstoqueItensCompra on itensCompra
for insert 
as 
BEGIN
    DECLARE @qtde   float,
	@codigo         integer

	SELECT @codigo = pro_cod, @qtde = itc_qtde FROM INSERTED

	update produto set pro_qtde = pro_qtde + @qtde where produto.pro_cod = @codigo
end
go