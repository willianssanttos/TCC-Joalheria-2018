USE [JOALHERIA]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[cat_cod] [int] IDENTITY(1,1) NOT NULL,
	[cat_nome] [varchar](95) NULL,
 CONSTRAINT [XPKcategoria] PRIMARY KEY NONCLUSTERED 
(
	[cat_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cli_cod] [int] IDENTITY(1,1) NOT NULL,
	[cli_datacadastro] [datetime] NULL,
	[cli_nome] [varchar](95) NULL,
	[cli_cpfcnpj] [varchar](95) NULL,
	[cli_rgie] [varchar](95) NULL,
	[cli_dtnascimento] [datetime] NULL,
	[cli_sexo] [varchar](95) NULL,
	[cli_rsocial] [varchar](95) NULL,
	[cli_tipo] [int] NULL,
	[cli_cep] [varchar](20) NULL,
	[cli_endereco] [varchar](95) NULL,
	[cli_bairro] [varchar](95) NULL,
	[cli_fone] [varchar](95) NULL,
	[cli_cel] [varchar](95) NULL,
	[cli_email] [varchar](95) NULL,
	[cli_endnumero] [varchar](10) NULL,
	[cli_cidade] [varchar](95) NULL,
	[cli_estado] [varchar](95) NULL,
	[cli_categoria] [varchar](95) NULL,
 CONSTRAINT [XPKcliente] PRIMARY KEY NONCLUSTERED 
(
	[cli_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[compra]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[com_cod] [int] IDENTITY(1,1) NOT NULL,
	[com_data] [datetime] NULL,
	[com_nfiscal] [int] NULL,
	[com_total] [money] NULL,
	[com_nparcelas] [int] NULL,
	[com_status] [int] NULL,
	[for_cod] [int] NULL,
	[tpa_cod] [int] NULL,
 CONSTRAINT [XPKcompra] PRIMARY KEY NONCLUSTERED 
(
	[com_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fornecedor](
	[for_cod] [int] IDENTITY(1,1) NOT NULL,
	[for_datacadastro] [datetime] NULL,
	[for_nome] [varchar](95) NULL,
	[for_rsocial] [varchar](95) NULL,
	[for_ie] [varchar](95) NULL,
	[for_cnpj] [varchar](95) NULL,
	[for_cep] [varchar](95) NULL,
	[for_endereco] [varchar](95) NULL,
	[for_bairro] [varchar](95) NULL,
	[for_fone] [varchar](95) NULL,
	[for_cel] [varchar](95) NULL,
	[for_email] [varchar](95) NULL,
	[for_endnumero] [varchar](95) NULL,
	[for_cidade] [varchar](95) NULL,
	[for_estado] [varchar](95) NULL,
	[for_sede] [varchar](95) NULL,
	[for_nacionalidade] [varchar](95) NULL,
 CONSTRAINT [XPKfornecedor] PRIMARY KEY NONCLUSTERED 
(
	[for_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[funcionario]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[funcionario](
	[func_cod] [int] IDENTITY(1,1) NOT NULL,
	[func_nome] [varchar](96) NULL,
	[func_dtnascimento] [datetime] NULL,
	[func_cpf] [varchar](96) NULL,
	[func_rg] [varchar](96) NULL,
	[func_sexo] [varchar](96) NULL,
	[func_telefone] [varchar](96) NULL,
	[func_celular] [varchar](96) NULL,
	[func_email] [varchar](96) NULL,
	[func-estad_civil] [varchar](96) NULL,
	[func_dependentes] [varchar](96) NULL,
	[func_nacionalidade] [varchar](96) NULL,
	[func_escolaridade] [varchar](96) NULL,
	[func_dt_admissao] [datetime] NULL,
	[func_car_fun] [varchar](96) NULL,
	[func_cart_detrabalho] [varchar](96) NULL,
	[func_cep] [varchar](96) NULL,
	[func_ende] [varchar](96) NULL,
	[func_bairro] [varchar](96) NULL,
	[func_cidade] [varchar](96) NULL,
	[func_uf] [varchar](96) NULL,
	[func_comissao] [varchar](96) NULL,
	[func_salario] [varchar](96) NULL,
 CONSTRAINT [XPKfuncionario] PRIMARY KEY NONCLUSTERED 
(
	[func_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itensvenda]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itensvenda](
	[itv_cod] [int] NOT NULL,
	[itv_qtde] [float] NULL,
	[itv_valor] [money] NULL,
	[ven_cod] [int] NOT NULL,
	[pro_cod] [int] NOT NULL,
 CONSTRAINT [XPKitensVenda] PRIMARY KEY NONCLUSTERED 
(
	[itv_cod] ASC,
	[ven_cod] ASC,
	[pro_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[parcelascompra]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcelascompra](
	[pco_cod] [int] NOT NULL,
	[pco_valor] [money] NULL,
	[pco_datapagto] [date] NULL,
	[pco_datavecto] [date] NULL,
	[com_cod] [int] NOT NULL,
 CONSTRAINT [XPKparcelascompra] PRIMARY KEY CLUSTERED 
(
	[pco_cod] ASC,
	[com_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[parcelasvenda]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcelasvenda](
	[ven_cod] [int] NOT NULL,
	[pve_cod] [int] NOT NULL,
	[pve_valor] [money] NULL,
	[pve_datapagto] [date] NULL,
	[pve_datavecto] [date] NULL,
 CONSTRAINT [XPKparcelasvenda] PRIMARY KEY CLUSTERED 
(
	[ven_cod] ASC,
	[pve_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[produto]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[produto](
	[pro_cod] [int] IDENTITY(1,1) NOT NULL,
	[pro_nome] [varchar](95) NULL,
	[pro_descricao] [varchar](95) NULL,
	[pro_foto] [image] NULL,
	[pro_valorpago] [money] NULL,
	[pro_valorvenda] [money] NULL,
	[pro_qtde] [float] NULL,
	[umed_cod] [int] NULL,
	[cat_cod] [int] NULL,
	[scat_cod] [int] NULL,
	[data_cadastro] [datetime] NULL,
	[fornecedor] [varchar](95) NULL,
	[ultmovalorcom] [money] NULL,
	[codigo_barras] [int] NULL,
 CONSTRAINT [XPKproduto] PRIMARY KEY NONCLUSTERED 
(
	[pro_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subcategoria]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subcategoria](
	[scat_cod] [int] IDENTITY(1,1) NOT NULL,
	[scat_nome] [varchar](95) NULL,
	[cat_cod] [int] NULL,
 CONSTRAINT [XPKsubcategoria] PRIMARY KEY NONCLUSTERED 
(
	[scat_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipopagamento]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipopagamento](
	[tpa_cod] [int] NOT NULL,
	[tpa_nome] [varchar](90) NULL,
 CONSTRAINT [XPKtipopagamento] PRIMARY KEY CLUSTERED 
(
	[tpa_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[undmedida]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[undmedida](
	[umed_cod] [int] IDENTITY(1,1) NOT NULL,
	[umed_nome] [varchar](95) NULL,
 CONSTRAINT [XPKmedida] PRIMARY KEY NONCLUSTERED 
(
	[umed_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[venda]    Script Date: 12/03/2018 21:03:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[ven_cod] [int] IDENTITY(1,1) NOT NULL,
	[ven_data] [datetime] NULL,
	[ven_nfiscal] [int] NULL,
	[ven_total] [money] NULL,
	[ven_nparcelas] [int] NULL,
	[ven_status] [int] NULL,
	[cli_cod] [int] NULL,
	[tpa_cod] [int] NULL,
 CONSTRAINT [XPKvenda] PRIMARY KEY NONCLUSTERED 
(
	[ven_cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [R_21] FOREIGN KEY([for_cod])
REFERENCES [dbo].[fornecedor] ([for_cod])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [R_21]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [R_24] FOREIGN KEY([tpa_cod])
REFERENCES [dbo].[tipopagamento] ([tpa_cod])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [R_24]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [R_13] FOREIGN KEY([ven_cod])
REFERENCES [dbo].[venda] ([ven_cod])
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [R_13]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [R_14] FOREIGN KEY([pro_cod])
REFERENCES [dbo].[produto] ([pro_cod])
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [R_14]
GO
ALTER TABLE [dbo].[parcelascompra]  WITH CHECK ADD  CONSTRAINT [R_25] FOREIGN KEY([com_cod])
REFERENCES [dbo].[compra] ([com_cod])
GO
ALTER TABLE [dbo].[parcelascompra] CHECK CONSTRAINT [R_25]
GO
ALTER TABLE [dbo].[parcelasvenda]  WITH CHECK ADD  CONSTRAINT [R_22] FOREIGN KEY([ven_cod])
REFERENCES [dbo].[venda] ([ven_cod])
GO
ALTER TABLE [dbo].[parcelasvenda] CHECK CONSTRAINT [R_22]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_11] FOREIGN KEY([cat_cod])
REFERENCES [dbo].[categoria] ([cat_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_11]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_12] FOREIGN KEY([scat_cod])
REFERENCES [dbo].[subcategoria] ([scat_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_12]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [R_9] FOREIGN KEY([umed_cod])
REFERENCES [dbo].[undmedida] ([umed_cod])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [R_9]
GO
ALTER TABLE [dbo].[subcategoria]  WITH CHECK ADD  CONSTRAINT [R_10] FOREIGN KEY([cat_cod])
REFERENCES [dbo].[categoria] ([cat_cod])
GO
ALTER TABLE [dbo].[subcategoria] CHECK CONSTRAINT [R_10]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [R_20] FOREIGN KEY([cli_cod])
REFERENCES [dbo].[cliente] ([cli_cod])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [R_20]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [R_23] FOREIGN KEY([tpa_cod])
REFERENCES [dbo].[tipopagamento] ([tpa_cod])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [R_23]
GO
