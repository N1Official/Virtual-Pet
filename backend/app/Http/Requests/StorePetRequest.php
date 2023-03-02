<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StorePetRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     *
     * @return bool
     */
    public function authorize()
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, mixed>
     */
    public function rules()
    {
        return [
            "name" =>"required|min:1|max:15",
            "type" =>"required",
            "hunger"=>"required",
            "thirst"=>"required",
            "mood"=>"required",
            "speed"=>"required",
            "health"=>"required",
            "skill"=>"required",
            "age"=>"required",
            "age_group"=>"required",
        ];
    }
}
