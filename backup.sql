--
-- PostgreSQL database dump
--

-- Dumped from database version 15.2
-- Dumped by pg_dump version 15.2

-- Started on 2023-05-23 11:44:04

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 215 (class 1259 OID 16428)
-- Name: qr_info; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.qr_info (
    id integer NOT NULL,
    image bytea[],
    content_encode text,
    date_created timestamp without time zone
);


ALTER TABLE public.qr_info OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 16427)
-- Name: qr_info_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.qr_info_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.qr_info_id_seq OWNER TO postgres;

--
-- TOC entry 3323 (class 0 OID 0)
-- Dependencies: 214
-- Name: qr_info_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.qr_info_id_seq OWNED BY public.qr_info.id;


--
-- TOC entry 3173 (class 2604 OID 16431)
-- Name: qr_info id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.qr_info ALTER COLUMN id SET DEFAULT nextval('public.qr_info_id_seq'::regclass);


--
-- TOC entry 3175 (class 2606 OID 16435)
-- Name: qr_info pk_qr_info; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.qr_info
    ADD CONSTRAINT pk_qr_info PRIMARY KEY (id);


-- Completed on 2023-05-23 11:44:04

--
-- PostgreSQL database dump complete
--

