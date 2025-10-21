using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AgropecuarioCliente.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AgropecuarioCliente.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private readonly JsonSerializerSettings _jsonSettings;

        public ApiService()
        {
            _httpClient = new HttpClient();
            _baseUrl = "http://localhost:8081/api/productos";
            _httpClient.Timeout = TimeSpan.FromSeconds(30);

            _jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Include,
                DateFormatString = "yyyy-MM-ddTHH:mm:ss"
            };
        }

        public async Task<List<ProductoAgricola>> ObtenerTodosAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(_baseUrl);
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoAgricola>>>(jsonContent, _jsonSettings);

                return apiResponse?.Data ?? new List<ProductoAgricola>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener productos: {ex.Message}");
            }
        }

        public async Task<ProductoAgricola> ObtenerPorIdAsync(string id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    return null;

                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ProductoAgricola>>(jsonContent, _jsonSettings);

                return apiResponse?.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener producto por ID: {ex.Message}");
            }
        }

        public async Task<ProductoAgricola> CrearAsync(ProductoAgricola producto)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(producto, _jsonSettings);
                System.Diagnostics.Debug.WriteLine($"JSON enviado: {jsonContent}");

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(_baseUrl, content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error del servidor: {response.StatusCode} - {errorContent}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ProductoAgricola>>(responseContent, _jsonSettings);

                return apiResponse?.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear producto: {ex.Message}");
            }
        }

        public async Task<ProductoAgricola> ActualizarAsync(string id, ProductoAgricola producto)
        {
            try
            {
                producto.Id = id;

                var jsonContent = JsonConvert.SerializeObject(producto, _jsonSettings);
                System.Diagnostics.Debug.WriteLine($"JSON enviado para actualizar: {jsonContent}");

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{_baseUrl}/{id}", content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error del servidor: {response.StatusCode} - {errorContent}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ProductoAgricola>>(responseContent, _jsonSettings);

                return apiResponse?.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar producto: {ex.Message}");
            }
        }

        public async Task<bool> EliminarAsync(string id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{_baseUrl}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar producto: {ex.Message}");
            }
        }

        public async Task<List<ProductoAgricola>> BuscarPorNombreAsync(string nombre)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}?nombre={Uri.EscapeDataString(nombre)}");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoAgricola>>>(jsonContent, _jsonSettings);

                return apiResponse?.Data ?? new List<ProductoAgricola>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar por nombre: {ex.Message}");
            }
        }

        public async Task<List<ProductoAgricola>> BuscarPorTipoAsync(string tipo)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}?tipo={Uri.EscapeDataString(tipo)}");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoAgricola>>>(jsonContent, _jsonSettings);

                return apiResponse?.Data ?? new List<ProductoAgricola>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar por tipo: {ex.Message}");
            }
        }

        public async Task<List<ProductoAgricola>> BuscarPorTemporadaAsync(string temporada)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}?temporada={Uri.EscapeDataString(temporada)}");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoAgricola>>>(jsonContent, _jsonSettings);

                return apiResponse?.Data ?? new List<ProductoAgricola>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar por temporada: {ex.Message}");
            }
        }

        public async Task<List<ProductoAgricola>> BuscarPorRangoHectareasAsync(double min, double max)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}?hectareasMin={min}&hectareasMax={max}");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoAgricola>>>(jsonContent, _jsonSettings);

                return apiResponse?.Data ?? new List<ProductoAgricola>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar por rango de hectáreas: {ex.Message}");
            }
        }
        // ===== MÉTODOS PARA COSECHAS =====

        public async Task<List<Cosecha>> ObtenerTodasCosechasAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://localhost:8081/api/cosechas");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Cosecha>>>(jsonContent, _jsonSettings);

                return apiResponse?.Data ?? new List<Cosecha>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener cosechas: {ex.Message}");
            }
        }

        public async Task<List<Cosecha>> ObtenerCosechasPorProductoAsync(string productoId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"http://localhost:8081/api/cosechas/producto/{productoId}");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Cosecha>>>(jsonContent, _jsonSettings);

                return apiResponse?.Data ?? new List<Cosecha>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener cosechas del producto: {ex.Message}");
            }
        }

        public async Task<Cosecha> ObtenerCosechaPorIdAsync(string id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"http://localhost:8081/api/cosechas/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    return null;

                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Cosecha>>(jsonContent, _jsonSettings);

                return apiResponse?.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener cosecha por ID: {ex.Message}");
            }
        }

        public async Task<Cosecha> CrearCosechaAsync(Cosecha cosecha)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(cosecha, _jsonSettings);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("http://localhost:8081/api/cosechas", content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error del servidor: {response.StatusCode} - {errorContent}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Cosecha>>(responseContent, _jsonSettings);

                return apiResponse?.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear cosecha: {ex.Message}");
            }
        }

        public async Task<Cosecha> ActualizarCosechaAsync(string id, Cosecha cosecha)
        {
            try
            {
                cosecha.Id = id;

                var jsonContent = JsonConvert.SerializeObject(cosecha, _jsonSettings);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"http://localhost:8081/api/cosechas/{id}", content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error del servidor: {response.StatusCode} - {errorContent}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<Cosecha>>(responseContent, _jsonSettings);

                return apiResponse?.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar cosecha: {ex.Message}");
            }
        }

        public async Task<bool> EliminarCosechaAsync(string id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"http://localhost:8081/api/cosechas/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar cosecha: {ex.Message}");
            }
        }
        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }

    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public DateTime Timestamp { get; set; }
    }
}