/**
 * SISTEMA DE GESTIÓN AGROPECUARIA
 * Universidad de Ibagué
 * components-loader.js - Cargador de componentes HTML
 */

/**
 * Carga componentes HTML en elementos con atributo data-component
 */
async function loadComponents() {
    const components = document.querySelectorAll('[data-component]');

    for (const element of components) {
        const componentName = element.getAttribute('data-component');
        const componentPath = `../components/${componentName}.html`;

        try {
            const response = await fetch(componentPath);
            if (response.ok) {
                const html = await response.text();
                element.innerHTML = html;
                console.log(`[ComponentLoader] ${componentName} cargado exitosamente`);
            } else {
                console.error(`[ComponentLoader] Error al cargar ${componentName}: ${response.status}`);
            }
        } catch (error) {
            console.error(`[ComponentLoader] Error al cargar ${componentName}:`, error);
        }
    }
}

// Cargar componentes cuando el DOM esté listo
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', loadComponents);
} else {
    loadComponents();
}

console.log('[ComponentLoader] Módulo de carga de componentes inicializado');
