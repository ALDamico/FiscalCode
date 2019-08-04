CREATE INDEX idx_foreign_countries on Foreign_Countries (foreign_country_name);

create index idx_municipalities on Italian_Municipalities (municipality_name);

create index idx_municipalities_name_alt on Italian_Municipalities (municipality_name_alternative);

create index idx_provinces on Italian_Provinces (province_name);

create index idx_provinces_abbr on Italian_Provinces (province_abbr);