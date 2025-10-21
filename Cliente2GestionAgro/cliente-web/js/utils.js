// Utilidades pequeñas
export function qs(selector, root = document){
  return root.querySelector(selector);
}

export function qsa(selector, root = document){
  return Array.from(root.querySelectorAll(selector));
}

export function create(tag, attrs = {}){
  const el = document.createElement(tag);
  Object.entries(attrs).forEach(([k,v]) => el.setAttribute(k,v));
  return el;
}
