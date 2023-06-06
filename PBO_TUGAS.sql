CREATE TABLE IF NOT EXISTS sell.laptop
(
    nama text COLLATE pg_catalog."default" NOT NULL,
    harga numeric NOT NULL,
    stok integer NOT NULL,
    CONSTRAINT laptop_pkey PRIMARY KEY (nama)
)

CREATE TABLE IF NOT EXISTS sell.transaksi
(
    nama_pembeli text COLLATE pg_catalog."default" NOT NULL,
    alamat_pembeli text COLLATE pg_catalog."default" NOT NULL,
    no_hp character(15) COLLATE pg_catalog."default" NOT NULL,
    tgl_transaksi character varying(20) COLLATE pg_catalog."default" NOT NULL,
    terjual text COLLATE pg_catalog."default" NOT NULL,
    jumlah integer NOT NULL,
    CONSTRAINT transaksi_pkey PRIMARY KEY (nama_pembeli)
)