
CREATE TABLE [categoria_produto]
( 
	[catprod_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[catprod_nome]           varchar(40)  NULL 
)
go

ALTER TABLE [categoria]
	ADD CONSTRAINT [XPKcategoria] PRIMARY KEY  NONCLUSTERED ([cat_cod] ASC)
go

CREATE TABLE [undmedida]
( 
	[umed_cod]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[umed_nome]          varchar(40)  NULL 
)
go

ALTER TABLE [undmedida]
	ADD CONSTRAINT [XPKmedida] PRIMARY KEY  NONCLUSTERED ([umed_cod] ASC)
go

CREATE TABLE [fornecedor]
( 
	[for_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[for_datacadastro]   datetime NULL,
	[for_nome]           varchar(40)  NULL ,
	[for_rsocial]        varchar(40)  NULL ,
	[for_ie]             varchar(40)  NULL ,
	[for_cnpj]           varchar(40)  NULL ,
	[for_cep]            char(08)  NULL ,
	[for_endereco]       varchar(40)  NULL ,
	[for_bairro]         varchar(40)  NULL ,
	[for_fone]           char(14)  NULL ,
	[for_cel]            varchar(40)  NULL ,
	[for_email]          varchar(40)  NULL ,
	[for_endnumero]      varchar(10)  NULL ,
	[for_cidade]         varchar(40)  NULL ,
	[for_estado]         char(02)  NULL ,
	[for_sede]           varchar(40)  NULL ,
	[for_nacionalidade]  varchar(40)  NULL
)
go

ALTER TABLE [fornecedor]
	ADD CONSTRAINT [XPKfornecedor] PRIMARY KEY  NONCLUSTERED ([for_cod] ASC)
go

CREATE TABLE [produto]
( 
	[pro_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[umed_cod]           int  NULL ,
	[cat_cod]            int  NULL ,
	[scat_cod]           int  NULL ,
	[codigo_barras]      int NULL ,
	[data_cadastro]      datetime NULL,
	[pro_nome]           varchar(40)  NULL ,
	[pro_descricao]      varchar(40)  NULL ,
	[pro_foto]           image  NULL ,
	[pro_valorpago]      money  NULL ,
	[pro_valorvenda]     money  NULL ,
	[pro_qtde]           float  NULL ,
	[pro_esto_atual]     float  NULL,
	[fornecedor]         varchar(40) NULL,
	[ultmovalorcom]      money NULL
	
)
go

ALTER TABLE [produto]
	ADD CONSTRAINT [XPKproduto] PRIMARY KEY  NONCLUSTERED ([pro_cod] ASC)
go

CREATE TABLE [tb_forn_prod]
(
   [cod_forn]               int NOT NULL IDENTITY (1,1) ,
   [cod_prod]               int NULL ,
)
go
CREATE TABLE [cliente]
( 
	[cli_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[cli_tipo]           int  NULL ,
	[cli_datacadastro]   datetime NULL, 
	[cli_nome]           varchar(40)  NULL ,
	[cli_cpfcnpj]        varchar(40)  NULL ,
	[cli_rgie]           varchar(40)  NULL ,
	[cli_dtnascimento]   datetime NULL,
	[cli_sexo]           varchar(40)  NULL ,
	[cli_rsocial]        varchar(40)  NULL ,
	[cli_cep]            char(08)  NULL ,
	[cli_endereco]       varchar(40)  NULL ,
	[cli_bairro]         varchar(40)  NULL ,
	[cli_fone]           char(14)  NULL ,
	[cli_cel]            varchar(40)  NULL ,
	[cli_email]          varchar(40)  NULL ,
	[cli_endnumero]      varchar(10)  NULL ,
	[cli_cidade]         varchar(40)  NULL ,
	[cli_estado]         char(02)  NULL 
)
go

ALTER TABLE [cliente]
	ADD CONSTRAINT [XPKcliente] PRIMARY KEY  NONCLUSTERED ([cli_cod] ASC)
go

CREATE TABLE  [funcionario]
(
   [func_cod]            int NOT NULL  IDENTITY ( 1,1) ,
   [func_nome]           varchar(40) NULL ,
   [func_dtnascimento]   datetime  NULL ,
   [func_cpf]            varchar(11) NULL ,
   [func_rg]             varchar(10) NULL ,
   [func_sexo]           varchar(02) NULL ,
   [func_telefone]       varchar(14) NULL ,
   [func_celular]        varchar(14) NULL ,
   [func_email]          varchar(40) NULL ,
   [func_escolaridade]   varchar(40) NULL ,
   [func_dt_admissao]    datetime NULL ,
   [func_car_fun]        varchar(40) NULL ,
   [func_cep]            varchar(08) NULL ,
   [func_ende]           varchar(40) NULL ,
   [func_bairro]         varchar(40) NULL ,
   [func_cidade]         varchar(40) NULL ,
   [func_uf]             varchar(02) NULL 
)
go

ALTER TABLE [funcionario]
	ADD CONSTRAINT [XPKfuncionario] PRIMARY KEY  NONCLUSTERED ([func_cod] ASC)
go


CREATE TABLE [subcategoria]
( 
	[scat_cod]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[cat_cod]            int  NULL , 
	[scat_nome]          varchar(40)  NULL 
	 
)
go

ALTER TABLE [subcategoria]
	ADD CONSTRAINT [XPKsubcategoria] PRIMARY KEY  NONCLUSTERED ([scat_cod] ASC)
go

CREATE TABLE [formapagamento]
( 
	[fpa_cod]            int  NOT NULL ,
	[fpa_nome]           varchar(40)  NULL 
)
go

ALTER TABLE [formapagamento]
	ADD CONSTRAINT [XPKformapagamento] PRIMARY KEY  CLUSTERED ([fpa_cod] ASC)
go


CREATE TABLE [compra]
( 
	[com_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[com_nfiscal]        int  NULL ,
	[com_nparcelas]      int  NULL ,
	[com_status]         int  NULL ,
	[for_cod]            int  NULL ,
	[fpa_cod]            int  NULL ,
	[com_data]           datetime  NULL ,
	[com_total]          money  NULL 
	  
)
go

ALTER TABLE [compra]
	ADD CONSTRAINT [XPKcompra] PRIMARY KEY  NONCLUSTERED ([com_cod] ASC)
go

CREATE TABLE [parcelascompra]
( 
	[pco_cod]            int  NOT NULL ,
	[com_cod]            int  NOT NULL ,
	[pco_valor]          money  NULL ,
	[pco_datapagto]      date  NULL ,
	[pco_datavecto]      date  NULL 
)
go

ALTER TABLE [parcelascompra]
	ADD CONSTRAINT [XPKparcelascompra] PRIMARY KEY  CLUSTERED ([pco_cod] ASC,[com_cod] ASC)
go


CREATE TABLE [itenscompra]
( 
	[itc_cod]            int  NOT NULL ,
	[com_cod]            int  NOT NULL ,
	[pro_cod]            int  NOT NULL , 
	[itc_qtde]           float  NULL ,
	[itc_valor]          money  NULL 
	
)
go

ALTER TABLE [itenscompra]
	ADD CONSTRAINT [XPKitenscompra] PRIMARY KEY  NONCLUSTERED ([itc_cod] ASC,[com_cod] ASC,[pro_cod] ASC)
go


CREATE TABLE [venda]
( 
	[ven_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[ven_nfiscal]        int  NULL ,
	[ven_nparcelas]      int  NULL ,
	[ven_status]         int  NULL ,
	[cli_cod]            int  NULL ,
	[tpa_cod]            int  NULL ,
	[ven_data]           datetime  NULL ,
	[ven_total]          money  NULL 
	
)
go

ALTER TABLE [venda]
	ADD CONSTRAINT [XPKvenda] PRIMARY KEY  NONCLUSTERED ([ven_cod] ASC)
go

CREATE TABLE [itensvenda]
( 
	[itv_cod]            int  NOT NULL ,
	[ven_cod]            int  NOT NULL ,
	[pro_cod]            int  NOT NULL ,
	[itv_qtde]           float  NULL ,
	[itv_valor]          money  NULL ,
	
)
go

ALTER TABLE [itensvenda]
	ADD CONSTRAINT [XPKitensVenda] PRIMARY KEY  NONCLUSTERED ([itv_cod] ASC,[ven_cod] ASC,[pro_cod] ASC)
go

CREATE TABLE [parcelasvenda]
( 
	[ven_cod]            int  NOT NULL ,
	[pve_cod]            int  NOT NULL ,
	[pve_valor]          money  NULL ,
	[pve_datapagto]      date  NULL ,
	[pve_datavecto]      date  NULL 
)
go

ALTER TABLE [parcelasvenda]
	ADD CONSTRAINT [XPKparcelasvenda] PRIMARY KEY  CLUSTERED ([ven_cod] ASC,[pve_cod] ASC)
go


ALTER TABLE [compra]
	ADD CONSTRAINT [R_21] FOREIGN KEY ([for_cod]) REFERENCES [fornecedor]([for_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [compra]
	ADD CONSTRAINT [R_24] FOREIGN KEY ([tpa_cod]) REFERENCES [tipopagamento]([tpa_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [parcelascompra]
	ADD CONSTRAINT [R_25] FOREIGN KEY ([com_cod]) REFERENCES [compra]([com_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [produto]
	ADD CONSTRAINT [R_9] FOREIGN KEY ([umed_cod]) REFERENCES [undmedida]([umed_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [produto]
	ADD CONSTRAINT [R_11] FOREIGN KEY ([cat_cod]) REFERENCES [categoria]([cat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [produto]
	ADD CONSTRAINT [R_12] FOREIGN KEY ([scat_cod]) REFERENCES [subcategoria]([scat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [itenscompra]
	ADD CONSTRAINT [R_15] FOREIGN KEY ([com_cod]) REFERENCES [compra]([com_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [itenscompra]
	ADD CONSTRAINT [R_17] FOREIGN KEY ([pro_cod]) REFERENCES [produto]([pro_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [subcategoria]
	ADD CONSTRAINT [R_10] FOREIGN KEY ([cat_cod]) REFERENCES [categoria]([cat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [venda]
	ADD CONSTRAINT [R_20] FOREIGN KEY ([cli_cod]) REFERENCES [cliente]([cli_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [venda]
	ADD CONSTRAINT [R_23] FOREIGN KEY ([tpa_cod]) REFERENCES [formapagamento]([tpa_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [itensvenda]
	ADD CONSTRAINT [R_13] FOREIGN KEY ([ven_cod]) REFERENCES [venda]([ven_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [itensvenda]
	ADD CONSTRAINT [R_14] FOREIGN KEY ([pro_cod]) REFERENCES [produto]([pro_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [parcelasvenda]
	ADD CONSTRAINT [R_22] FOREIGN KEY ([ven_cod]) REFERENCES [venda]([ven_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [usuario]
	ADD CONSTRAINT [R_36] FOREIGN KEY ([cod_nivel]) REFERENCES [nivel_acesso]([cod_nivel])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

