
CREATE TABLE Pessoa
(
	PessoaID INT IDENTITY PRIMARY KEY,
	DsNome   VARCHAR(100),
);

CREATE TABLE Credential
(
	CredentialID INT IDENTITY PRIMARY KEY,
	DsLogin      VARCHAR(200),
	DsSenha      VARCHAR(100),
	PessoaID     INT
	FOREIGN KEY(PessoaID) REFERENCES Pessoa(PessoaID)
);

CREATE TABLE TipoDica(
	TipoID INT IDENTITY PRIMARY KEY,
	DsTipo VARCHAR(100)
)

CREATE TABLE Dica(
	DicaID INT IDENTITY PRIMARY KEY,
	PessoaID INT NOT NULL ,
	TipoID INT NOT NULL,
	DsTitulo VARCHAR(100),
	DsDescricao VARCHAR(1000),
	DtDataInclusao DATETIME,
	FOREIGN KEY(PessoaID) REFERENCES Pessoa(PessoaID) 
		ON DELETE cascade
		ON UPDATE CASCADE,
	FOREIGN KEY(TipoID) REFERENCES TipoDica(TipoID)
		ON DELETE cascade
		ON UPDATE CASCADE
);

